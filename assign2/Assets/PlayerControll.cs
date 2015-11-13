using UnityEngine;
using System.Collections;

public class PlayerControll : MonoBehaviour {

	public float moveSpeed = 0.5f;
	public bool grounded = true;
    public float jumpPower = 15;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 tempPosition = transform.position;
		if(Input.GetAxis("Horizontal")>0){
			tempPosition.x += moveSpeed;
		}
		if(Input.GetAxis("Horizontal")<0){
			tempPosition.x -= moveSpeed;
		}
		

		transform.position = tempPosition;
		
		if(!grounded && GetComponent<Rigidbody2D>().velocity.y == 0) {
         grounded = true;
     	}
   		if (Input.GetButtonDown("Jump") && grounded == true) {
         GetComponent<Rigidbody2D>().AddForce(transform.up*jumpPower);
         grounded = false;
     	}

	}
}
