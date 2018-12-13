/* 
 * Created by Joe Chung
 * Copyright 2017 
 * joechung.me
 */

using UnityEngine;

/// <summary>
/// Wing collider that allows Boxes to be counted.
/// To be attached to Left Collider gameobject.
/// </summary>
public class LeftPlaneCollider : MonoBehaviour {

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "one"){
			EquationController.leftOneCount++;
		} 
		else if (other.gameObject.tag == "x"){
			EquationController.leftXCount++;
		}	
	}

	void OnCollisionExit (Collision other)
	{
		if (other.gameObject.tag == "one") {
			EquationController.leftOneCount--;
		} 
		else if (other.gameObject.tag == "x"){
			EquationController.leftXCount--;
		}
	}
		
}
