using UnityEngine;

namespace Configurator
{
    public class SampleCore : MonoBehaviour
    {
        [SerializeField] private Base _sampleBase;
        [SerializeField] private Attachment _sampleAttachment;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (_sampleBase.GetPoint(out var point))
                {
                    point.AttachIfNotOccupied(_sampleAttachment);
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if (_sampleBase.GetPoint(out var point))
                {
                    point.Detach();
                }
            }
        }
    }
}