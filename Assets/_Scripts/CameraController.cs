using UnityEngine;

namespace LP.ARPGNewInputTutorial
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform target = null;
        [SerializeField] private Vector3 offset = new Vector3();
        [SerializeField] private float pitch = 2f;

        private void LateUpdate()
        {
            transform.position = target.position - offset;
            transform.LookAt(target.position + Vector3.up * pitch);
        }
    }
}

