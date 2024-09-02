using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RigidBody : MonoBehaviour
{
    public float speed;
    public Vector2 inputVector;
    public Rigidbody Rigidbody;
    public int Jumpforce;
    public bool CanJump;
    public Collision Contacto;
    public int puntos;
    public TMPro.TextMeshProUGUI TextoPuntos;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        CanJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        Rigidbody.AddForce(inputVector.x * speed, 0f, inputVector.y * speed, ForceMode.Impulse);

        
        if(Input.GetKeyDown(KeyCode.Space) && CanJump)
        {
            Rigidbody.AddForce(0f, Jumpforce, 0f, ForceMode.Impulse);
            CanJump = false;
        }


        
        
    }
    private void OnCollisionEnter(Collision Contacto)
    {
        Debug.Log("Choque contra: " + Contacto.gameObject.name);
        if (Contacto.gameObject.CompareTag("Nivel"))
        {
            CanJump = true;
        }

        if (Contacto.gameObject.CompareTag("KillZone"))
        {
            SceneManager.LoadScene(0); 
        }

        if(Contacto.gameObject.CompareTag("Goal"))
        {
            SceneManager.LoadScene(1);
        }

        if(Contacto.gameObject.CompareTag("Item"))
        {
            Destroy(Contacto.gameObject);
            puntos++;
            TextoPuntos.text = puntos.ToString();
        }
    }
}

