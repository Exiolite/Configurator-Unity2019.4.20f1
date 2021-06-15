using UnityEngine;

namespace Configurator
{
    public class AttachmentPoint : MonoBehaviour
    {
        [SerializeField] private AttachmentPointPreset _pointType;

        private Attachment _attachment;
        

        public bool TryAttach(Attachment attachment)
        {
            
            if (_attachment == null)
            {
                if (attachment.AttachmentPoint._pointType == _pointType)
                {
                    _attachment = Instantiate(attachment, transform);
                    _attachment.SetPosAndRotTo(this);
                    return true;
                }
            }
            
            if (_attachment != null)
                return _attachment.Attach(attachment);
            
            return false;
        }
    }
}