using UnityEngine;
using System.Collections;

public class blueAI : MonoBehaviour {
	public float speed = 2f;
	public float Distance = 10f;
	float Travel = 0;
	float rotate = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){
		if (Distance > Travel) {
			transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
			Travel+=speed;
		} else {
			transform.Rotate (new Vector3 (0, 0, -3), Space.Self);
			transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
			rotate += 3;
			if (rotate == 90){
				Travel = 0;
				rotate = 0;
			}
		}
	}
}
