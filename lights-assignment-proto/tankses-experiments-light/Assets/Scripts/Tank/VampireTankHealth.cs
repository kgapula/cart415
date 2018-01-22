using UnityEngine;
using UnityEngine.UI;

namespace Complete
{
    public class VampireTankHealth : TankHealth
    {

        public Light m_Sun;
        public Transform[] m_WeakPoints;
        public float m_SunDamage = 0.5f;
        public float m_Regen = 0.01f;

        //create a variable to check whether or not the tank is allowed to shoot
        //we want the tank to shoot only if it's in sunlight
        public static bool inLight;

        private Vector3 m_ReverseSun;

        protected override void Awake()
        {
            base.Awake();

            m_ReverseSun = -m_Sun.transform.forward; 
        }

        public void Update()
        {
            bool damage = false;
            inLight = false;
            for (int i = 0; i < m_WeakPoints.Length; i++)
            {
                if (!Physics.Raycast(m_WeakPoints[i].position, m_ReverseSun, 100f, LayerMask.GetMask("Default")))
                {
                    Debug.DrawRay(m_WeakPoints[i].position, m_ReverseSun * 100, Color.green);
                    damage = true;
                    inLight = true;
                }
                else {
                    Debug.DrawRay(m_WeakPoints[i].position, m_ReverseSun * 100, Color.red);
                }
            }
            if (damage)
            {
                TakeDamage(m_SunDamage);
            } else
            {
                TakeDamage(-m_Regen);
            }
        }
    }
}