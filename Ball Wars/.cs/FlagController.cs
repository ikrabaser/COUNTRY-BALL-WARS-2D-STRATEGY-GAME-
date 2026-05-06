using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    public string country;
    public bool isPlayer;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isPlayer)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            rb.velocity = new Vector2(h, v) * moveSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isPlayer) return;
        GameObject fx = Instantiate(GameManager.Instance.hitEffectPrefab, transform.position, Quaternion.identity);
        Destroy(fx, 1f);
        GameManager.Instance.AddScore(1);
    }
}
