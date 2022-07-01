using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
public Rigidbody sspher;
	float speed=3.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		float v = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
		transform.Translate (h,v,0f);
		if (Input.GetMouseButtonDown(0)) {

			Rigidbody rig=Instantiate(sspher ,transform.position,transform.rotation) as Rigidbody;
			rig.AddForce(transform.forward*2000f);
			Destroy(rig.gameObject,1);
		}
	
	}
}
