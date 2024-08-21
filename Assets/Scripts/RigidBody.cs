using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody : MonoBehaviour
{
    public float speed;
    public Vector2 inputVector;
    public Rigidbody Rigidbody;
    public int Jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        Rigidbody.AddForce(inputVector.x * speed, 0f, inputVector.y * speed, ForceMode.Impulse);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(0f, Jumpforce, 0f, ForceMode.Impulse);
        }
    }
}
