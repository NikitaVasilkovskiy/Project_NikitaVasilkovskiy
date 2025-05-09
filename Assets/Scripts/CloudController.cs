using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TTZ
{
    public class CloudController : MonoBehaviour
    {
        private int m_targetIndex = 0;
        private bool m_moved = false;
        public float moveSpeed = 10f;
        public Transform[] targets;
        public void Action()
        {
            Debug.Log("Cloud", this);

            if (m_moved)
            {
                return;
            }
            m_moved = true;
            m_targetIndex++;
            if (m_targetIndex >= targets.Length) { m_targetIndex = 0; }
        }
        public void Update()
        {
            if(!m_moved)
            { return; }

            
        }
    }
}