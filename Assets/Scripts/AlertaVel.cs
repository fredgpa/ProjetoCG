using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlertaVel : MonoBehaviour {
    public GameObject carro;
    public Image alerta;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        var vel = carro.GetComponent<Velocidade>();
        if (vel.velocidade > 40)
            alerta.enabled = true;
        else
            alerta.enabled = false;
    }
}
