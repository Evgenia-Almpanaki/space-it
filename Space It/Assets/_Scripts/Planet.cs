using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private float originalDistance;

    private new Transform transform;
    private float speed;

    private void Awake()
    {
        transform = GetComponent<Transform>();
        speed = originalDistance * 15; 
        transform.position = new Vector3(originalDistance, 0, originalDistance);
    }

    void Update()
    {
        speed += Random.Range(0.5f, 2f);
        transform.position = new Vector2((originalDistance * Mathf.Sin(Mathf.Deg2Rad * speed)),
                                         (originalDistance / 2 * Mathf.Cos(Mathf.Deg2Rad * speed)));
    }
}
