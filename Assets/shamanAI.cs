using UnityEngine;
using System.Collections;

public class shamanAI : MonoBehaviour {
	public GameObject type1;
	public GameObject type2;
	public GameObject type3;
	int count = 0;
	int max = 2;
	int period = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		if(count <= max && period > 100){
			position.x += Random.Range(0,4);
			period = 0;
			int choice = Random.Range(0,3);
			switch(choice){
			case 0:
				Instantiate(type1, position, transform.rotation);
				break;
			case 1:
				Instantiate(type2, position, transform.rotation);
				break;
			case 2:
				Instantiate(type3, position, transform.rotation);
				break;
			}
		}
		period++;
	}
}
