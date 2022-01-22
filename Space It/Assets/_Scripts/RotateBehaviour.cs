using UnityEngine;

public class RotateBehaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    private new Transform transform;

    private void Awake()
    {
        transform = GetComponent<Transform>();
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }
}
