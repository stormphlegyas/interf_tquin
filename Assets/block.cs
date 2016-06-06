// ************************************************************************** //
//                                                                            //
//                                                        :::      ::::::::   //
//   block.cs                                           :+:      :+:    :+:   //
//                                                    +:+ +:+         +:+     //
//   By: mmounini <mmounini@student.42.fr>          +#+  +:+       +#+        //
//                                                +#+#+#+#+#+   +#+           //
//   Created: 2016/06/05 20:03:36 by mmounini          #+#    #+#             //
//   Updated: 2016/06/06 02:28:18 by mmounini         ###   ########.fr       //
//                                                                            //
// ************************************************************************** //

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class block : MonoBehaviour {
	public int				num;
	Vector3					np;
	bool					trans;
	// Use this for initialization
	void Start () {
		trans = false;
		np = transform.position;
	}

	public void move(Vector3 pos){
		np = pos;
		trans = true;
	}

	public void init_num(int nb){
		num = nb;
		GetComponent<Text> ().text = nb.ToString();
		if ( nb == 0 ) {
			transform.GetChild (0).GetComponent<MeshRenderer> ().enabled = false;
			GetComponent<Text> ().text = "";
		}
		np = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (trans == true) {
			transform.Translate ((np - transform.position).normalized * Time.deltaTime * 2, Space.World);
			if (Vector3.Distance (np, transform.position) < 0.1) {
				transform.position = np;
				trans = false;
			}
		}
	}
}
