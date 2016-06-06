// ************************************************************************** //
//                                                                            //
//                                                        :::      ::::::::   //
//   block.cs                                           :+:      :+:    :+:   //
//                                                    +:+ +:+         +:+     //
//   By: mmounini <mmounini@student.42.fr>          +#+  +:+       +#+        //
//                                                +#+#+#+#+#+   +#+           //
//   Created: 2016/06/05 20:03:36 by mmounini          #+#    #+#             //
//   Updated: 2016/06/05 20:03:37 by mmounini         ###   ########.fr       //
//                                                                            //
// ************************************************************************** //

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class block : MonoBehaviour {
	public int				num;
	// Use this for initialization
	void Start () {

	}

	public void move(Vector3 pos){
		transform.position = pos;
	}

	public void init_num(int nb){
		num = nb;
		GetComponent<Text> ().text = nb.ToString();
		if ( nb == 0 ) {
			transform.GetChild (0).GetComponent<MeshRenderer> ().enabled = false;
			GetComponent<Text> ().text = "";
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
