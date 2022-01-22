using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private float speed = 10f;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, speed++ * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Planet"))
        {
            Destroy(other.gameObject); 
            audioSource.Play();

        }
        Destroy(this.gameObject);
    }
}
