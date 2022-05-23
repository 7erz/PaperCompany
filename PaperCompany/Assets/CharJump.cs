using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharJump : MonoBehaviour
{
    Rigidbody2D rb;            // Rigidbody2D 클래스를 가진 변수 rb
    public float jumpPower;    // jumpPower변수 공개 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        // Rigidbody2D라는 컴포넌트를 rb에 넣겠다.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 = Mouse left
            // 마우스 좌클릭을 할 때 힘을 받아서 위로 움직이겠다
        {
            rb.velocity = Vector2.up * jumpPower; 
        }
    }
}
