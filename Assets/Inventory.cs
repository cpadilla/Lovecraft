using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour 
{
	public bool [] Inv;
	public GameObject Bag;
	bool isOpen;

	// Use this for initialization
	void Start () 
	{
		Inv = new bool[48];
		isOpen = true;
	}

	// Update is called once per frame
	void Update () 
	{
	if (Input.GetKeyDown (KeyCode.I))
		{
		if (isOpen == true)
			{
				Bag.SetActive (false);
				isOpen = false;
			}
		else 
			{
			Bag.SetActive (true);
			isOpen = true;
			}
		}

	}
}