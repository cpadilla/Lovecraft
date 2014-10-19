using UnityEngine;
using System.Collections;

public class Clues : MonoBehaviour 
{
        public int Number;
        public string ClueText;

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
			int x = int.Parse(gameObject.name.Substring(6));
			I.Inv [x] = true;		
		}
	}
	void OnTriggerExit2D(Collider2D obj){
		if (obj.tag == "Player") Destroy(gameObject);
	}
}
