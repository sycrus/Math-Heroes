/* 
 * Created by Joe Chung
 * Copyright 2017 
 * joechung.me
 */

using UnityEngine;

/// <summary>
/// Zone above left wing that allows Boxes and Balloons to be activated.
/// To be attached to Left Trigger gameobject.
/// </summary>
public class onLeftTrigger : MonoBehaviour { //only for gravity

	private Vector3 localPos;

	void OnTriggerEnter (Collider other) {

		if (other.gameObject.tag == "one") {
			//make objects fall onto plane
			other.attachedRigidbody.useGravity = true;
			other.attachedRigidbody.isKinematic = false;
		} 
		else if (other.gameObject.tag == "x" ) {
			//make objects fall onto plane
			other.attachedRigidbody.useGravity = true;
			other.attachedRigidbody.isKinematic = false;

		}
		else if (other.gameObject.tag == "minusOne") {
			//decrease one count
			EquationController.leftOneCount--;
		}
		else if (other.gameObject.tag == "minusX") {
			//decrease one count
			EquationController.leftXCount--;
		}
	}

	void OnTriggerExit (Collider other) {
		
		if (other.gameObject.tag == "x" || other.gameObject.tag == "one") {

			other.attachedRigidbody.useGravity = false;
			other.attachedRigidbody.isKinematic = true;

			//make objects float back into original position
			localPos = other.attachedRigidbody.transform.localPosition; //cannot set transform directly
			localPos.y = 1;
			other.attachedRigidbody.transform.localPosition = localPos;

		}
		else if (other.gameObject.tag == "minusOne") { // remove minusOne = increase one count
			EquationController.leftOneCount++;
		}
		else if (other.gameObject.tag == "minusX") { // remove minusX = increase x count
			EquationController.leftXCount++;
		}
	}

}
			

