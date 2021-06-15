using System.Collections;
using UnityEngine;

namespace Configurator
{
    public class SampleCore : MonoBehaviour
    {
        [SerializeField] private Attachment _base;
        [SerializeField] private Attachment _attachment1;
        [SerializeField] private Attachment _attachment2;
        [SerializeField] private Attachment _attachment3;
        [SerializeField] private Attachment _attachment4;
        [SerializeField] private Attachment[] _attachments;


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                _base.Attach(_attachment1);
            
            if (Input.GetKeyDown(KeyCode.Alpha2))
                _base.Attach(_attachment2);
            
            if (Input.GetKeyDown(KeyCode.Alpha3))
                _base.Attach(_attachment3);
            
            if (Input.GetKeyDown(KeyCode.Alpha4))
                _base.Attach(_attachment4);

            if (Input.GetKeyDown(KeyCode.R))
                StartCoroutine(Spawner());

        }

        private IEnumerator Spawner()
        {
            for (int i = 0; i < 1000; i++)
            {
                _base.Attach(_attachments[Random.Range(0, _attachments.Length)]);
                yield return new WaitForSeconds(0.01f);
            }
        }
    }
}