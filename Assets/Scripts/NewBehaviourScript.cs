using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Vector3 newPosition;
    public float Speed;
    public Vector2 inputVector;
    void Start()
    {
        Debug.Log("Game start");

    }

    // Update is called once per frame
    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        transform.Translate(inputVector.x * Speed, 0f, inputVector.y * Speed);
       
    }
}
