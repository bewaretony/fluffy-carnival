using UnityEngine;
using System.Collections;

public class Spinner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    transform.localRotation = Quaternion.Euler(transform.eulerAngles + new Vector3(0, 1f, 0));
	}
}
