using System;
using UnityEngine;

namespace Configurator
{
    public class Attachment : MonoBehaviour
    {
        [SerializeField] private AttachmentPoint _baseAttachPoint;

        private Transform _transform;
        
        
        private void Awake() => _transform = GetComponent<Transform>();

        
        public void AttachTo(AttachmentPoint point)
        {
            _transform.rotation = point.transform.rotation;
            _transform.position = point.transform.position - (_baseAttachPoint.transform.position - _transform.position);
        }
    }
}