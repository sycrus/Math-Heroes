/* 
 * Created by Joe Chung
 * Copyright 2017 
 * joechung.me
 */

using UnityEngine;

/// <summary>
/// Creates zero pairs.
/// To be attached to -x and -1.
/// </summary>
public class ZeroPairController : MonoBehaviour {

	private Vector3 thisPos;
	private Vector3 thatPos;

	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "one"|| other.gameObject.tag == "x") {
			other.attachedRigidbody.useGravity = false;
			other.attachedRigidbody.isKinematic = true;
		}
		if (this.gameObject.tag == "minusOne" && other.gameObject.tag == "one") {

			//make touched object float about triggerzone
			thatPos = other.transform.localPosition; //cannot set transform directly
			thatPos.y = 10;
			other.transform.localPosition = thatPos;

			//make this object float about triggerzone
			thisPos = this.transform.localPosition; //cannot set transform directly
			thisPos.y = 10;
			this.transform.localPosition = thisPos;
		}
		if (this.gameObject.tag == "minusX" && other.gameObject.tag == "x") {

			//make touched object float about triggerzone
			thatPos = other.transform.localPosition; //cannot set transform directly
			thatPos.y = 10;
			other.transform.localPosition = thatPos;

			//make this object float about triggerzone
			thisPos = this.transform.localPosition; //cannot set transform directly
			thisPos.y = 10;
			this.transform.localPosition = thisPos;
		}

	}
}
