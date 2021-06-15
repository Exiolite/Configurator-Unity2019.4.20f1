using UnityEngine;

namespace Configurator
{
    public class SampleCore : MonoBehaviour
    {
        [SerializeField] private Attachment _base;
        [SerializeField] private Attachment _attachment;
        [SerializeField] private Attachment _attachment2;


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                _base.Attach(_attachment);
            
            if (Input.GetKeyDown(KeyCode.Alpha2))
                _base.Attach(_attachment2);
        }
    }
}