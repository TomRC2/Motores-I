using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CosasDeMapa : MonoBehaviour
{

    public Vector2 inputVector;
    public Rigidbody Rigidbody;
    public Collision Contacto;
    public int puntos;
    public TMP_Text TextoPuntos;

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

        if (Contacto.gameObject.CompareTag("Goal"))
        {
            SceneManager.LoadScene(1);
        }

        if (Contacto.gameObject.CompareTag("Item"))
        {
            Destroy(Contacto.gameObject);
            puntos++;
            TextoPuntos.text = puntos.ToString();
        }
    }
}

