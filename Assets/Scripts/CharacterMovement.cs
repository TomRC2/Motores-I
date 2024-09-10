using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RigidBody : MonoBehaviour
{
   
    public Vector2 inputVector;
    public Rigidbody Rigidbody;
    public Collision Contacto;
    public int puntos;
<<<<<<<< HEAD:Assets/Scripts/Cosas de mapa.cs
    public TMPro.TextMeshPro TextoPuntos;
   
========
    public TMPro.TextMeshProUGUI TextoPuntos;
    // Start is called before the first frame update
>>>>>>>> 14fc5a9aadbb89064e5f74af177a7f4efbb2d380:Assets/Scripts/CharacterMovement.cs
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        
    }

    
    private void OnCollisionEnter(Collision Contacto)
    {
        

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

