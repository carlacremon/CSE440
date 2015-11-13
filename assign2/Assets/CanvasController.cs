using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour {
	Text counterText;
	public static int triggerEnterCounter = 0;


	// Use this for initialization
	void Start () {
		counterText = gameObject.GetComponent<Text> ();
		counterText.text = "color changes: " + triggerEnterCounter;

	}
	
	// Update is called once per frame
	void Update () {
		counterText.text = "color changes: " + triggerEnterCounter;
	
	}

	public static void CounterUpdate(){
		triggerEnterCounter += 1;
	}
}
