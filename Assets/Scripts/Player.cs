using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //1
    public int speed;

    //2
    public int jumpPower;
    private Rigidbody2D rb;
    //3
    public int jumpCount;

    public int coinScore;


    void Start()
    {
        //2
        rb = GetComponent<Rigidbody2D>();
        jumpCount = 0;
        coinScore = 0;
    }

    void Update()
    {
        //1��. �÷��̾� �����̱�
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, 0, 0);
        transform.Translate(direction);

        //2��. �÷��̾� �����ϱ�
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount > 0)
        {
            rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jumpCount--;
        }
    }

    // 3�� : �浹ó��
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        if (collision.collider.CompareTag("Ground"))
        {
            jumpCount = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Coin"))
        {
            coinScore++;
        }
    }
}
