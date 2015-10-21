using UnityEngine;
using System.Collections;

public class PeachTexture : MonoBehaviour {

	private int index=0;
	private SpriteRenderer spriteRenderer;
	private int number;




	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<Renderer>() as SpriteRenderer;
	}
	
	// Update is called once per frame
	void Update () {	

		if (Input.GetMouseButtonDown(0)){ // if left mouse button pressed...
			GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f));
			
		}
		
	}
	
}

