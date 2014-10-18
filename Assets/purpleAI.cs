using UnityEngine;
using System.Collections;

public class purpleAI : MonoBehaviour {
	public Transform target;//set target from inspector instead of looking in Update
	public float speed = 2f;
	
	
	///Inizialization///
	void Start ()
	{

	}
	
	
	///Fixed Update///
	void Update ()
	{
		transform.LookAt(target.position);
		transform.Rotate(new Vector3(0,-90,0),Space.Self);//correcting the original rotation

		//move towards the player
		if (Vector3.Distance(transform.position,target.position)>0.5f){
			transform.Translate(new Vector3(speed* Time.deltaTime,0,0) );
		}
	}
}
