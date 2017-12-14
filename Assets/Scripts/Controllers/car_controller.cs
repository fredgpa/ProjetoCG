using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_controller : MonoBehaviour {

	public object car;
    public float speed;
    public int acc = 5;
    public int brk = 0;
    // Use this for initialization
    void Start () {
		car = GameObject.FindGameObjectWithTag ("Car");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.up * acc * Time.deltaTime, Space.World);

		} 
		else {
			transform.Translate (Vector3.up * brk * Time.deltaTime, Space.World);
		}
	}
}
