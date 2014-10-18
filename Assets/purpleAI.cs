using UnityEngine;
using System.Collections;

public class purpleAI : MonoBehaviour {
	public Transform target;//set target from inspector instead of looking in Update
	public float speed = 2f;
	//int count=0;
	///Inizialization///
	void Start ()
	{

	}
	
	
	///Fixed Update///
	void Update ()
	{
		Vector3 dir = target.position - transform.position;
		float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		if (Vector3.Distance(transform.position,target.position)>0.5f){
			transform.Translate(new Vector3(speed* Time.deltaTime,0,0));
		}
		/* Original movement
		transform.LookAt(target.position);
		transform.Rotate(new Vector3(0,-90,0),Space.Self);//correcting the original rotation

		if (Vector3.Distance(transform.position,target.position)>0.5f){
			transform.Translate(new Vector3(speed* Time.deltaTime,0,0));
		}
		*/
		//move towards the player
		/*
		if (Vector3.Distance(transform.position,target.position)>0.5f){
			if(count<50){
				Vector3 temp = target.position;
				temp.x+=1;
				temp.y+=1;
				Vector3 dir = temp - transform.position;
				float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
				transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
				count++;
			}else{
				Vector3 temp = target.position;
				temp.x-=1;
				temp.y-=1;
				Vector3 dir = temp - transform.position;
				float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
				transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
				count++;
				if(count>=100) count=0;
			}
			transform.Translate(new Vector3(speed* Time.deltaTime,0,0) );
		}
		*/
	}
}
