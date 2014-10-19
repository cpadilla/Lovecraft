using UnityEngine;
using System.Collections;

public class ActivateShaman : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D obj)
	{
		// if obj == "Room" Playerentering rooom = true
		shamanAI temp = transform.parent.gameObject.GetComponent<shamanAI>();
		if (obj.tag == "Player")  temp.Active = true;
		//print("Hit");
	}
}
