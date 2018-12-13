/* 
 * Created by Joe Chung
 * Copyright 2017
 * joechung.me
 */

using UnityEngine;

/// <summary>
/// Stores the X value. Set in the Inspector.
/// </summary>
public class XValue : MonoBehaviour {
	public static float xValue = 0;
	public float xVal = 0;

	void Update() {
		SetXValue ();
	}

	void SetXValue(){
		xValue = xVal;
	}
}
