using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;
    private Vector3 _offset;
    
    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x + _offset.x, target.position.y + _offset.y, target.position.z + _offset.z);
    }
}
