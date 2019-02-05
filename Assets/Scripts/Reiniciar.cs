using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    private Button btnReiniciar;
    
    void Start()
    {
        btnReiniciar = GetComponent<Button>();
        btnReiniciar.onClick.AddListener(reiniciar);
    }


    void Update()
    {
        
    }

    void reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
