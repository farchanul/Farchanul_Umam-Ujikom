using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoy : MonoBehaviour
{
    public float MoveSpeed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float moveX = x * MoveSpeed;
        Debug.Log(moveX);
       // rb.Velocity= new Vector3(moveX, rb.Velocity.y, 0);
        transform.Translate(moveX,0,0);
    }
}
