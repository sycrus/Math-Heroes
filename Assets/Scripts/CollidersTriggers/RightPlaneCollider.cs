/* 
 * Created by Joe Chung
 * Copyright 2017 
 * joechung.me
 */

using UnityEngine;

/// <summary>
/// Wing collider that allows Boxes to be counted.
/// To be attached to Right Collider gameobject.
/// </summary>
public class RightPlaneCollider : MonoBehaviour {

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "one") {
			EquationController.rightOneCount++;
		}
		else if (other.gameObject.tag == "x"){
			EquationController.rightXCount++;
		}
	}

	void OnCollisionExit (Collision other)
	{
		if (other.gameObject.tag == "one") {
			EquationController.rightOneCount--;
		}
		else if (other.gameObject.tag == "x"){
			EquationController.rightXCount--;
		}
	}
}
