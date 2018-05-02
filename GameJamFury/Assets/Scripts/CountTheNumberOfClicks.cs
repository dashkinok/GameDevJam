using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountTheNumberOfClicks : MonoBehaviour {

	int counter = 0;


	public void ButtonClick(){
	
		counter++;
		Debug.Log (counter);

	
	}


}
