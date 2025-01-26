using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D _rb;
    public bool grounded;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            _rb.AddForce(Vector3.right * speed);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            _rb.AddForce(Vector3.left * speed);
        }

        if (grounded == true)
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                _rb.AddForce(Vector2.up * (speed * 10));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }
}
