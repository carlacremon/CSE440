using UnityEngine;
using System.Collections;

public class TriggerHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other) {
       // Destroy(other.gameObject);
		other.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f));
		Debug.Log("oie");
    }
}
