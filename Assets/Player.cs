using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

        public static WorldTile.Coord location;
        
        public int X;
        public int Y;
        
        public static bool EnteringRoom = false;
        public static GoDirection LastStep;
            
        public float Speed = 5f;

	// Use this for initialization
	void Start () {
            location.X = 0;
            location.Y = 0;
	}
	
	// Update is called once per frame
	void Update () {
            //print("Player is " + ((EnteringRoom) ? "" : "not ") +"entering Room");

            X = location.X;
            Y = location.Y;

            rigidbody2D.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * Speed, 0.8f),
                                                   Mathf.Lerp(0, Input.GetAxis("Vertical") * Speed, 0.8f));
	}

        void OnTriggerEnter2D(Collider2D obj)
        {
            // if obj == "Room" Playerentering rooom = true
            if (obj.tag == "Room") EnteringRoom = true;
            //print("Hit");
        }

        void OnTriggerExit2D(Collider2D obj)
        {
		if (gameObject.tag == "Clue")
		{
			Destroy(gameObject);
		}

            // if obj == "Room" Playerentering rooom = true
            if (obj.tag == "Room") EnteringRoom = false;
            //print("Hit");
        }
}
