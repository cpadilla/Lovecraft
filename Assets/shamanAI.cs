using UnityEngine;
using System.Collections;

public class shamanAI : MonoBehaviour {
	public GameObject type1;
	public GameObject type2;
	public GameObject type3;
	int count = 0;
	int max = 3;
	int period = 0;
	public bool Active = false;
	private WorldTile tile;
	int x,y;
	// Use this for initialization
	void Start () {
		x = (int)(transform.position.x);
		y = (int)(transform.position.y);
		tile = World.TryGetTile((int)(transform.position.x)/8,((int)(transform.position.y)/6));
		transform.parent = tile.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(Player.location.X == x && Player.location.Y == y){
			if(Active){
				Vector3 position = transform.position;
				if(count <= max && period > 100){
					position.x += Random.Range(1,2);
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
					count++;
				}
			}
			period++;
		}
	}
}
