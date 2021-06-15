using UnityEngine;
using Random = UnityEngine.Random;

namespace Configurator
{
    public class Base : MonoBehaviour
    {
        private AttachmentPoint[] _points;

        private void Awake()
        {
            _points = GetComponentsInChildren<AttachmentPoint>();
        }

        public bool GetPoint(out AttachmentPoint point)
        {
            if (_points != null)
            {
                point = _points[Random.Range(0, _points.Length)];
                return true;
            }

            point = null;
            return false;
        }
    }
}
