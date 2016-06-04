using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour {

	bool	play;
	int		id;
	void	init(){
		play = true;
		id = 7;
	}
	// Use this for initialization
	void Start () {
		play = false;
		//GetComponent<loadder>().canvas.GetComponent<GridLayoutGroup> ().enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (play == false)
			init ();
		else
			GetComponent<loadder>().canvas.GetComponent<GridLayoutGroup> ().enabled = false;
		Debug.Log (GetComponent<loadder>().str[id]);
		if (GetComponent<loadder>().str[id] != "]" && GetComponent<loadder>().str[id] != "END")
			id++;
	}
}
