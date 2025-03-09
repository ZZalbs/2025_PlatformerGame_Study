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
    public int jumpCount;

    void Start()
    {
        //2
        rb = GetComponent<Rigidbody2D>();
        jumpCount = 0;
    }

    void Update()
    {
        //1강. 플레이어 움직이기
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime*speed, 0, 0);
        transform.Translate(direction);
        
        //2강. 플레이어 점프하기
        if(Input.GetKeyDown(KeyCode.Space)&&jumpCount>0)
        {
            rb.AddForce(Vector2.up*jumpPower,ForceMode2D.Impulse);
            jumpCount--;
        }
    }

    // 3강 : 충돌처리
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        if(collision.collider.CompareTag("Ground"))
        {
            jumpCount = 1;
        }
    }
}
