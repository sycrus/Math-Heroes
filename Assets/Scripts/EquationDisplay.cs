/* 
 * Created by Joe Chung
 * Copyright 2017 
 * joechung.me
 */

using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Displays the equation.
/// </summary>

public class EquationDisplay : MonoBehaviour {
	public Text leftText;
	public Text rightText;

	// Use this for initialization
	void Start () {
		rightText.text = "0";
		leftText.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		SetLeftText();
		SetRightText();
	}

    /// <summary>
    /// Sets the left equation text.
    /// </summary>
	void SetLeftText()
	{

		if (EquationController.leftXCount == 0) { // x = 0
			if (EquationController.leftOneCount == 0) { // x = 0 && one = 0
				leftText.text = "0";
			}
			else { // x = 0 only
				leftText.text = EquationController.leftOneCount.ToString();
			}
		} 
		else {
			if (EquationController.leftOneCount == 0) { // x != 0 and  one = 0
				
				if (EquationController.leftXCount == 1) { // x = 1 and one = 0
					leftText.text = "x";
				} 
				else if (EquationController.leftXCount == -1) { // x = 1 and one = 0
					leftText.text = "-x";
				} 
				else { 									  // x != 1 and one = 0
					leftText.text = EquationController.leftXCount.ToString() + "x";
				}
			} 
			else { 	
				if (EquationController.leftXCount == 1) { // x = 1 and one != 0
					leftText.text = "x " + "+ " + "( " + EquationController.leftOneCount.ToString() + " )";
				} // x != 0 and one ! = 0
				else if (EquationController.leftXCount == -1) { // x = -1 and one != 0
					leftText.text = "-x " + "+ " + "( " + EquationController.leftOneCount.ToString() + " )";
				} 
				leftText.text = EquationController.leftXCount.ToString() + "x " + "+ " + "( " + EquationController.leftOneCount.ToString() + " )";
			}
		}
	}

    /// <summary>
    /// Sets the right equation text.
    /// </summary>
	void SetRightText()
	{

		if (EquationController.rightXCount == 0) { // x = 0
			if (EquationController.rightOneCount == 0) { // x = 0 && one = 0
				rightText.text = "0";
			}
			else { // x = 0 only
				rightText.text = EquationController.rightOneCount.ToString();
			}
		} 
		else {
			if (EquationController.rightOneCount == 0) { // x != 0 and  one = 0

				if (EquationController.rightXCount == 1) { // x = 1 and one = 0
					rightText.text = "x";
				} 
				else if (EquationController.rightXCount == -1) { // x = 1 and one = 0
					rightText.text = "-x";
				} 
				else { 									  // x != 1 and one = 0
					rightText.text = EquationController.rightXCount.ToString() + "x";
				}
			} 
			else { 	
				if (EquationController.rightXCount == 1) { // x = 1 and one != 0
					rightText.text = "x " + "+ " + "( " + EquationController.rightOneCount.ToString() + " )";
				} // x != 0 and one ! = 0
				else if (EquationController.rightXCount == -1) { // x = -1 and one != 0
					rightText.text = "-x " + "+ " + "( " + EquationController.rightOneCount.ToString() + " )";
				} 
				rightText.text = EquationController.rightXCount.ToString() + "x " + "+ " + "( " + EquationController.rightOneCount.ToString() + " )";
			}
		}
	}
		
}
