using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector2 direction;
    public int speed;
    void Start()
    {
        direction = Vector2.left;
        StartCoroutine(ChangeDir());
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    //4°­
    IEnumerator ChangeDir()
    {
        while (true)
        {
            speed *= -1;
            yield return new WaitForSeconds(1f);
        }
    }
}
