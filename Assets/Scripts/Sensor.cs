using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour {

    public GameObject Receptor1;
    public GameObject Receptor2;
    public LayerMask mascaraPlayer;
    float distancia;
    Vector3 direcao;

    // Use this for initialization
    void Start () {
        float distancia = (Receptor1.transform.position - Receptor2.transform.position).magnitude;
        Vector3 direcao = (Receptor1.transform.position - Receptor2.transform.position)/distancia;
    }

	
	// Update is called once per frame
	void Update () {
        //if (!Physics.Linecast(Receptor1.transform.position, Receptor2.transform.position, mascaraPlayer))
	}
}
