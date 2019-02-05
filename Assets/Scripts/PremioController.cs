using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PremioController : MonoBehaviour
{
    static private int contadorPremioAdquiridos;
    public int limiteMaximo = 33;
    private new Rigidbody rigidbody;
    public Text marcador;
    public Text winText;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        contadorPremioAdquiridos = 0;
        setMarcador();
        winText.text = "";
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coche") && winText.text.Length <= 0)
        {
            contadorPremioAdquiridos++;
            setMarcador();
            Destroy(this.gameObject);
        }
    }

    private void setMarcador()
    {
        marcador.text = "Premios: " + contadorPremioAdquiridos.ToString();

        if (contadorPremioAdquiridos >= limiteMaximo)
        {
            winText.text = "¡Has ganado!";
            GameObject[] fuegos = GameObject.FindGameObjectsWithTag("FuegosArtificiales");

            foreach (GameObject fuego in fuegos)
            {
                fuego.GetComponent<ParticleSystem>().Play();
            }

        }
    }


}
