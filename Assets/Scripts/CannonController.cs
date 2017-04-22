using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {
	private float actualtime = 0f;
	private float coldowntime = 60f;
	private GameObject cannon;
	// Use this for initialization
	void Start () {
		//actualtime = Time.time;
		cannon = GameObject.FindGameObjectWithTag ("Cannon");
		Debug.Log("Hello", gameObject);
		cannon.SetActive (false);

	}

	void OnMouseDown(){
		Debug.Log (Time.time, gameObject);
		if ((!cannon.activeSelf && Time.time > actualtime + coldowntime) || actualtime == 0f) {
			actualtime = Time.time;
			cannon.SetActive (true);
			Global.bullets = 5;
		}
	}

	// Update is called once per frame
	void Update () {
	}
}
