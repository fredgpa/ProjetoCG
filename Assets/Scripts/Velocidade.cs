using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidade : MonoBehaviour {

    GameObject carro;
    public float velocidade = 0;
    Vector3 ultimaPos = Vector3.zero;



	// Use this for initialization
	void Start () {
        carro = GameObject.Find("Car");
	}
	
	// Update is called once per frame
	void Update () {

        velocidade = carro.GetComponent<Rigidbody>().velocity.magnitude * 3.6f;
    }
}
