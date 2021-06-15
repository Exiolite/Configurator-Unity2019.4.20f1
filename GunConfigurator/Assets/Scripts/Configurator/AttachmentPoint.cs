using UnityEngine;

namespace Configurator
{
    public class AttachmentPoint : MonoBehaviour
    {
        public bool IsBusy { get; private set; }

        public Attachment Attachment { get; private set; }

        public void AttachIfNotOccupied(Attachment attachment)
        {
            if (IsBusy) return;
            
            Attachment = Instantiate(attachment, transform);
            Attachment.AttachTo(this);
            IsBusy = true;
        }

        public void Detach()
        {
            if (!IsBusy) return;
            
            Destroy(Attachment.gameObject);
            IsBusy = false;
        }
    }
}