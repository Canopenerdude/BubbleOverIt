using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D _rb;
    public bool grounded;
    public string command;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        command = GetText.command;
        if (command != null)
        {
            MovementCommands();
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

    IEnumerator MovementCommands()
    {
        if (command is "right" or "Right")
        {
            Debug.Log(command);
            _rb.AddForce(Vector2.right * (speed * Time.timeScale));
            yield return new WaitForSeconds(1);
            command = null;
        }
        else if (command is "left" or "Left")
        {
            Debug.Log(command);
            _rb.AddForce(Vector2.left * (speed * Time.timeScale));
            yield return new WaitForSeconds(1);
            command = null;
        }

        if (grounded)
        {
            if (command is "jump" or "Jump")
            {
                Debug.Log(command);
                _rb.AddForce(Vector2.up * (speed * 10 * Time.timeScale));
                yield return new WaitForSeconds(1);
                command = null;
            }
        }
    }

    public IEnumerator WaitingForMovement()
    {
        yield return new WaitForSeconds(1);
    }
}
