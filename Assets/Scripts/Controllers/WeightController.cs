/* 
 * Created by Joe Chung
 * Copyright 2017 
 * joechung.me
 */


using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Sets the weights of the left and right hand sides of the equation, assuming 
/// </summary>
public class WeightController : MonoBehaviour {
	public static float leftWeight = 0;
	public static float rightWeight = 0;

	void Update () {
		SetLeftWeight ();
		SetRightWeight ();
	}

	void SetLeftWeight() {

		WeightController.leftWeight = XValue.xValue * EquationController.leftXCount + EquationController.leftOneCount;

	}
	void SetRightWeight() {

		WeightController.rightWeight = XValue.xValue * EquationController.rightXCount + EquationController.rightOneCount;

	}

}
