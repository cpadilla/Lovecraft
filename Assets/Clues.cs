﻿using UnityEngine;
using System.Collections;

public class Clues : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D col) 
	{
		if (col.tag == "Player")
		{
			Inventory I = GameObject.Find ("Inventory").GetComponent<Inventory> ();
			int x = int.Parse (this.gameObject.name.Substring (5));
			Debug.Log (x);
			I.Inv [x] = true;
		}

	}
}
