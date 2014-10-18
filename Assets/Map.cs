using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

	// Use this for initialization
	void Start () {
            transform.rotation = Camera.main.transform.rotation;
            Vector3 camera = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0);
            transform.position = camera;
        }
	
	// Update is called once per frame
	void Update () {
            //Vector3 cam = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0);
            //transform.rotation = Camera.main.transform.rotation;
            //transform.position = cam;
	}
}
