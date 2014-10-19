using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour 
{
	public bool [] Inv;
	public GameObject Bag;
	int x,y;

	// Use this for initialization
	void Start () {
		gameObject.renderer.enabled = false;
		Inv = new bool[45];
	}

	// Update is called once per frame
	void Update () {
		for(int i=0; i<Inv.Length; i++){
			if(Inv[i]){
				
			}
		}
		x = Player.location.X*8;
		y = Player.location.Y*6;
		transform.Translate(new Vector3(x,y,0));
		if (Input.GetKeyDown (KeyCode.I)){
			if(gameObject.renderer.enabled == true)
				gameObject.renderer.enabled = false;
			else
				gameObject.renderer.enabled = true;
		}
	}
}