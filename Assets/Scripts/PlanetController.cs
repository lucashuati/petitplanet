using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour {
	int Life;
	private GameObject alien;
	// Use this for initialization
	void Start () {
		alien = GameObject.FindGameObjectWithTag("Alien");
		Life = 100;
	}

	IEnumerator Reborn(){
		yield return new WaitForSeconds (Random.Range(3,15));

		alien.SetActive (true);
	}
	// Update is called once per frame
	void Update () {
		//Debug.Log (Global.alien_death);
		if (Global.alien_death) {
			Global.alien_death = false;
			StartCoroutine (Reborn ());

		}
	}

	void death (){
	
	}
}
