using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

        public float Speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*
            float xinput = Input.GetAxis("Horizontal");
            float xPos = 0;
            if (xinput != 0) xPos = xinput * Speed;

            float yinput = Input.GetAxis("Vertical");
            float yPos = 0;
            if (yinput != 0) yPos = yinput * Speed;

            //transform.position = new Vector3(xPos, yPos, 0);
		*/
            rigidbody2D.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * Speed, 0.8f),
                                                   Mathf.Lerp(0, Input.GetAxis("Vertical") * Speed, 0.8f));
	}
}
