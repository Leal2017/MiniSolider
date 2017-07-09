using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplleMove : MonoBehaviour {

	void FixedUpdate () {
	    transform.Translate(5*Time.fixedDeltaTime*transform.forward);
	}
}
