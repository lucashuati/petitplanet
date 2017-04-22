using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour {
	private float deltaTime;
	private float rebornTime;

	// Use this for initialization
	void Start () {
		
	}

	void OnMouseDown(){
		if(Global.actual == "Cannon"){
			Global.actual = "None";
			GameObject cannon = GameObject.FindGameObjectWithTag ("Cannon");
			Global.bullets--;
			Global.alien_death = true;
			transform.position = new Vector3(-8.28f,transform.position.y, transform.position.z);
			gameObject.SetActive(false);

		}
			
	}
		
	// Update is called once per frame
	void Update () {
		//Debug.Log (Time.time);
		if (!gameObject.activeSelf) {
			Debug.Log (Time.time);
			if (Time.time == rebornTime) {
				gameObject.SetActive (true);
			}
		} else {
			
			if (transform.position.x < -2) {
				transform.Translate(Time.deltaTime,0,0);
			}
		}

	}
}
