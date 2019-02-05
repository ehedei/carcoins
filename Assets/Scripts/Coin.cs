using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public int value;
	
	void Start () {
		
	}
    
    void FixedUpdate()
    {
        transform.Rotate(0f, 0f, 2f);
    }
}
