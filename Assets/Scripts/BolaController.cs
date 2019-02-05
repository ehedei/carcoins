using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolaController : MonoBehaviour
{
    private new Rigidbody rigidbody;
    private int contadorPremioAdquiridos;
    public Text marcador;
    public Text winText;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        contadorPremioAdquiridos = 0;
        setMarcador();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moverHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3(moverHorizontal, 0.0f, moverVertical);
        rigidbody.AddForce(vector * 4.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Premio"))
        {
            other.gameObject.SetActive(false);
            contadorPremioAdquiridos++;
            setMarcador();
        }
    }

    private void setMarcador()
    {
        marcador.text = "Premios: " + contadorPremioAdquiridos.ToString();
        if (contadorPremioAdquiridos >= 12)
        {
            winText.text = "¡Has ganado!";
        }
    }
}
