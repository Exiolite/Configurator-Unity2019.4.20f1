using UnityEngine;

namespace Configurator
{
    [RequireComponent(typeof(Transform))]
    public class AttachmentPointUi : MonoBehaviour
    {
        [SerializeField] private bool _isEnabled;
        [SerializeField] private Transform _transform;


        private void Awake() => _transform.gameObject.SetActive(_isEnabled);

        private void LateUpdate()
        {
            _transform.LookAt(Camera.Transform);
            var distanceToCamera = Vector3.Distance(_transform.position, Camera.Transform.position)/10;
            _transform.localScale = new Vector3(distanceToCamera,distanceToCamera,distanceToCamera);
        }
    }
}