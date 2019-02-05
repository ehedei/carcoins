using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CronoController : MonoBehaviour
{

    public float tiempoMaximo = 150.0f;
    public Text winText;
    public Text contadorText;

    private float cuentaAtras = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        cuentaAtras = tiempoMaximo;
    }

    // Update is called once per frame
    void Update()
    {
        if (winText.text.Length <= 0)
        {
            if (cuentaAtras > 0)
            {
                cuentaAtras -= Time.deltaTime;
                contadorText.text = cuentaAtras.ToString("0.00");
            }
                
            else
            {
                contadorText.text = "0,00";
                contadorText.color = Color.red;
                winText.text = "Has perdido";
            }



        }

    }
}
