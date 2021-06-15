using UnityEngine;

namespace Configurator
{
    public class AttachmentPoint : MonoBehaviour
    {
        [SerializeField] private AttachmentPointPreset _pointType;

        private Attachment _attachment;
        

        public bool TryAttach(Attachment attachment)
        {
            if (attachment.AttachmentPoint._pointType == _pointType)
            {
                if (_attachment == null)
                {
                    _attachment = Instantiate(attachment, transform);
                    _attachment.SetPosAndRotTo(this);
                    return true;
                }
            }

            if (_attachment.Attach(attachment))
                return true;
            
            return false;
        }
    }
}