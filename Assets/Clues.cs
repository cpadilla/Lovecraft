﻿using UnityEngine;
using System.Collections;

public class Clues : MonoBehaviour 
{
        public int Number;
        public string ClueText;
        public AudioSource Sound;

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
			Inventory I = GameObject.Find("Inventory").GetComponent<Inventory> ();
			//int x = int.Parse(gameObject.name.Substring(6));
			int x = Number;
			I.Inv [x] = true;
                        Rect shrek = new Rect(Player.location.X * 8, Player.location.Y * 6, Screen.width, Screen.height);
                        GUI.Label(shrek, "Here is a block of text\nlalalala\nanother line\nI could do this all day!");
                    try
                    {
                        Sound.Play();
                    }
                    catch { }
		}
	}
	void OnTriggerExit2D(Collider2D obj){
		if (obj.tag == "Player") Destroy(gameObject);
	}
}
