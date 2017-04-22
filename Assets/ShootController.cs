using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global {
	public static string actual = "None";
	public static int bullets = 1;
	public static bool alien_death = false;
}
public class ShootController : MonoBehaviour {
	public int bullets;
	// Use this for initialization
	void Start () {
		
		
	}

	void OnMouseDown(){
		Global.actual = "Cannon";
		bullets--;
		Debug.Log (Global.bullets, gameObject);
		//GameObject target = GameObject.FindGameObjectWithTag ("Respawn");	
		//Destroy (target);
	}

	// Update is called once per frame
	void Update () {
		if (Global.bullets == 0) {
			gameObject.SetActive (false);
		}
	}
}
