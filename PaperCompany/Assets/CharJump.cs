using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharJump : MonoBehaviour
{
    Rigidbody2D rb;            // Rigidbody2D Ŭ������ ���� ���� rb
    public float jumpPower;    // jumpPower���� ���� 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        // Rigidbody2D��� ������Ʈ�� rb�� �ְڴ�.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 = Mouse left
            // ���콺 ��Ŭ���� �� �� ���� �޾Ƽ� ���� �����̰ڴ�
        {
            rb.velocity = Vector2.up * jumpPower; 
        }
    }
}
