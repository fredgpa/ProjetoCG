using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimapa : MonoBehaviour {

    public Camera mapa;
    public KeyCode tecla;
    int zoom = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(tecla))
        {
            zoom++;
            if (zoom == 3)
                zoom = 0;
        }
        switch (zoom)
        {
            case 0:
                mapa.orthographicSize = 70;
                break;
            case 1:
                mapa.orthographicSize = 200;
                break;
            case 2:
                mapa.orthographicSize = 30;
                break;
        }
	}
}
