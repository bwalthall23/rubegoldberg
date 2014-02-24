using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {
	// Use this for initialization
	public Transform BalloonBlocker;
	public float speed = 2.0f;
	public Camera camera1;
	public Camera maincamera;
	void Start () {
		maincamera.enabled = true;
		camera1.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.R)){
			Application.LoadLevel(0);
				}
	}
	void OnTriggerEnter (Collider other){
		BalloonBlocker.transform.Translate (transform.forward * speed * Time.deltaTime);
		maincamera.enabled = false;
		camera1.enabled = true;
	}
		
}
