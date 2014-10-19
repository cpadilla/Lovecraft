using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {
	float x=0f,y=0f;
	Transform position;
	// Use this for initialization
	void Start () {
		position = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(8 * Player.location.X - 3.1f, 6 * Player.location.Y - 2.7f, 0);
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