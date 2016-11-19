using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	[SerializeField]
	float speed;
	[SerializeField]
	float boundery;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow) && transform.position.x > -boundery) {
			transform.position += new Vector3 (-speed, 0, 0);

		} else if (Input.GetKey (KeyCode.RightArrow)  && transform.position.x < boundery) {
			transform.position += new Vector3 (speed, 0, 0);
		}

	}
}
