using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CosasDeMapa : MonoBehaviour
{
   
    public Vector2 inputVector;
    public Rigidbody Rigidbody;
    public Collision Contacto;
    public int puntos;
    public TextMeshPro TextoPuntos;

    public CosasDeMapa(TextMeshPro textoPuntos)
    {
        TextoPuntos = textoPuntos;
    }

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

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object other)
    {
        return base.Equals(other);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

