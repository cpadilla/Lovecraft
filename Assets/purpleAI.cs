using UnityEngine;
using System.Collections;

public class purpleAI : MonoBehaviour {
	float speed = 3f;
	
	
	///Inizialization///
	function Start ()
	{
		enemy = GameObject.FindGameObjectsWithTag("Enemy");
		player = GameObject.FindGameObjectsWithTag("Player");
	}
	
	
	///Fixed Update///
	function FixedUpdate ()
	{
		//Vector2.Distance = enemy.transform.position - player.transform.position
		range = Vector2.Distance(enemy.transform.position, player.transform.position);
		if(range <= 15f)
		{
			transform.Translate(Vector2.MoveTowards(enemy.transform.position, player.transform.position, range) * speed * Time.deltaTime);
		}
	}
}
