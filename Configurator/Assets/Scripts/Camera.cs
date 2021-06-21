using UnityEngine;

public class Camera : MonoBehaviour
{
        public static Transform Transform { get; private set; }

        private void Awake() => Transform = GetComponent<Transform>();
}