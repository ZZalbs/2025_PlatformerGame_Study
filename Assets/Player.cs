using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed;
    void Start()
    {
        
    }

    void Update()
    {
        //1강. 플레이어 움직이기
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime*speed, 0, 0);
        transform.Translate(direction);
    }
}
