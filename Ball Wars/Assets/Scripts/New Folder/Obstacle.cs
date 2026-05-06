using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float hareketHizi = 2f;

    void Update()
    {
        transform.Translate(Vector2.left * hareketHizi * Time.deltaTime);

        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
