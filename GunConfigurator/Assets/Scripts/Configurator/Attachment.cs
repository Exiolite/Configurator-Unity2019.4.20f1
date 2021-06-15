using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Configurator
{
    public class Attachment : MonoBehaviour
    {
        public AttachmentPoint AttachmentPoint => _attachmentPoint;
        
        [SerializeField] private AttachmentPoint _attachmentPoint;
        private List<AttachmentPoint> _attachmentPoints;

        private void Awake()
        {
            _attachmentPoints = GetComponentsInChildren<AttachmentPoint>().ToList();
            if (_attachmentPoints.Contains(_attachmentPoint)) _attachmentPoints.Remove(_attachmentPoint);
        }

        public bool Attach(Attachment attachment)
        {
            if (_attachmentPoints.Count <= 0) return false;
            
            foreach (var connectionPoint in _attachmentPoints)
            {
                if (connectionPoint.TryAttach(attachment)) return true;
            }

            return false;
        }

        public void SetPosAndRotTo(AttachmentPoint point)
        {
            transform.rotation = point.transform.rotation;
            transform.position = point.transform.position - (_attachmentPoint.transform.position - transform.position);
        }
    }
}