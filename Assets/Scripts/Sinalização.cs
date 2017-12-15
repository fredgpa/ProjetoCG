using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinalização : MonoBehaviour {

    bool Esq = false;
    bool Dir = false;
    GameObject setaEsq;
    GameObject setaDir;
    Vector3 posInicial;

	// Use this for initialization
	void Start () {
        setaEsq = GameObject.Find("SetaEsq");
        setaDir = GameObject.Find("SetaDir");
        
	}

	// Update is called once per frame
	void Update () {
        var sinalizarE = setaEsq.gameObject.GetComponent<Pisca>();
        var sinalizarD = setaDir.gameObject.GetComponent<Pisca>();
        

    }
}
