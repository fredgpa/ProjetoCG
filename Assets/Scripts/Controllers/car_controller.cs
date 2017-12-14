using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_controller : MonoBehaviour {

	public object car;
    public float speed;
    // Use this for initialization
    void Start () {
		car = GameObject.FindGameObjectWithTag ("Car");
	}

    public void findSpeed()
    {
        
    }
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.up * 5 * Time.deltaTime, Space.World);

		} 
		else {
			transform.Translate (Vector3.up * 0 * Time.deltaTime, Space.World);
		}
	}
}
