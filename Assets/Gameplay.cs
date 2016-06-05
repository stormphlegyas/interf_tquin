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

	bool	play;
	int		id;

	void	init(){
		play = true;
		id = 7;
	}
	IEnumerator 
	// Use this for initialization
	void Start () {
		play = false;
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
