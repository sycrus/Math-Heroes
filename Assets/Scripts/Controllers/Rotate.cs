/* 
 * Created by Joe Chung
 * Copyright 2017 
 * joechung.me
 */


using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Rotates the plane depending on left and right values.
/// </summary>
public class Rotate : MonoBehaviour {

	public float smooth = 1f;
	public float tiltAngle = 20f;

	public Text middleText; // =, < or  >
	private float tilt = 0;

	void Update () {
		if (WeightController.leftWeight > WeightController.rightWeight) {
			middleText.text = " > ";

			//rotate anticlockwise
			tilt = tiltAngle;
			Quaternion target = Quaternion.Euler(0, 0, tilt);
			transform.rotation = Quaternion.Lerp(transform.rotation, target, Time.deltaTime * smooth);

		}

		else if (WeightController.leftWeight < WeightController.rightWeight) {
			middleText.text = " < ";

			//rotate clockwise
			tilt = tiltAngle * -1;
			Quaternion target = Quaternion.Euler(0, 0, tilt);
			transform.rotation = Quaternion.Lerp(transform.rotation, target, Time.deltaTime * smooth);

		} else if (WeightController.leftWeight == WeightController.rightWeight) {
			middleText.text = " = ";

			//rotate until level
			Quaternion target = Quaternion.Euler(0, 0, 0);
			transform.rotation = Quaternion.Lerp(transform.rotation, target, Time.deltaTime * smooth);

		}
	}
}
