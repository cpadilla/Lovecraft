using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int children = transform.childCount;
		GameObject[] list = new GameObject[children];
		for (int i = 0; i < children; ++i)
			list[i] = transform.GetChild(i).gameObject;
		int health = Player.Health;
		for(int i=0; i<children; i++){
			if(health >= i){
				list[i].renderer.enabled = true;
			}else{
				list[i].renderer.enabled = false;
			}
		}
	}
}
