using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

        public float Speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

            

            rigidbody2D.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * Speed, 0.8f),
                                                   Mathf.Lerp(0, Input.GetAxis("Vertical") * Speed, 0.8f));
	}

        void OnTriggerEnter2D(Collider2D obj)
        {
            print("Hit");
        }
}
