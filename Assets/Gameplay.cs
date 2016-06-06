// ************************************************************************** //
//                                                                            //
//                                                        :::      ::::::::   //
//   Gameplay.cs                                        :+:      :+:    :+:   //
//                                                    +:+ +:+         +:+     //
//   By: mmounini <mmounini@student.42.fr>          +#+  +:+       +#+        //
//                                                +#+#+#+#+#+   +#+           //
//   Created: 2016/06/04 23:38:46 by mmounini          #+#    #+#             //
//   Updated: 2016/06/04 23:38:47 by mmounini         ###   ########.fr       //
//                                                                            //
// ************************************************************************** //

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour {

	int		id;
	GameObject[] obj;
	GameObject	bl_zero;
	string last;


	void	zero_to(int a){
		Debug.Log (a);
		for (int h = 0; h < obj.Length; h++) {
			Debug.Log (GetComponent<loadder> ().str [id] + " and id = " + id);
			if (obj [h].GetComponent<block> ().num == last [GetComponent<loadder> ().str [id].IndexOf ('0')] - 48) {
				Vector3 tmp = bl_zero.transform.position;
				bl_zero.GetComponent<block> ().move (obj [h].transform.position);
				obj [h].GetComponent<block> ().move (tmp);
			}
		}
	}

	IEnumerator animate(){
		last = GetComponent<loadder> ().str[7];
		yield return new WaitForEndOfFrame ();
		GetComponent<loadder>().canvas.GetComponent<GridLayoutGroup> ().enabled = false;
		for (id = 8; GetComponent<loadder> ().str [id] != "]" && GetComponent<loadder> ().str [id] != "END"; id++) {
			zero_to (last [GetComponent<loadder> ().str [id].IndexOf ('0')] - 48);
			last = GetComponent<loadder> ().str [id];
			yield return new WaitForSeconds (1);
		}

	}
	// Use this for initialization
	void Start () {
		StartCoroutine (animate());
		obj = GetComponent<loadder> ().block;
		for (int i = 0; i < obj.Length; i++) {
			if (obj [i].GetComponent<block> ().num == 0) {
				bl_zero = obj [i];
				break;
			}
		}
	}

	// Update is called once per frame
	void Update () {

			
/*		Debug.Log (GetComponent<loadder>().str[id]);
		if (GetComponent<loadder>().str[id] != "]" && GetComponent<loadder>().str[id] != "END")
			id++;*/
	}
}
