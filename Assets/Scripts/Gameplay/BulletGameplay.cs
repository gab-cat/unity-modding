using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        // Set the bullet to destroy itself after a certain time if needed
        Destroy(gameObject, 5f); // Destroys the bullet after 5 seconds
    }

    void Update()
    {
        // Move the bullet forward
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
