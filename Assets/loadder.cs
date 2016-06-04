using UnityEngine;
using System.Collections;
using System.Text;
using System.IO; 
using UnityEngine.UI;

public class loadder : MonoBehaviour {
	public RectTransform	canvas;
	public GameObject 		Case;
	StreamReader 			theReader;
	string 					line;
	public GameObject[]		block;
	public string[]			str;


	// Use this for initialization
	void Start () {
		int count = 2;
		int id = 7;
		theReader = new StreamReader("/Users/Phlegyas/Downloads/n-puzzle/output.txt", Encoding.Default);
		if (theReader.EndOfStream == false)
			line = theReader.ReadLine ();
		Debug.Log (line);
		theReader.Close ();
		str = line.Split (' ');
		canvas.sizeDelta = new Vector2 (int.Parse(str[1]) * 1.2f, int.Parse(str[1]) * 1.2f);
		block = new GameObject[ int.Parse (str [1]) * int.Parse (str [1]) ];
		block [0] = Case;
		str [id] = str [id].Split ('[') [1];
		int j = 1;
		Case.GetComponent<Text> ().text = (str [id] [0] - 48).ToString();
		if ((str [id] [j] - 48) == 0) {
			Case.transform.GetChild (0).GetComponent<MeshRenderer> ().enabled = false;
			Case.GetComponent<Text> ().text = "";
		}
		for (int i = 0; i < (int.Parse(str[1]) * int.Parse(str[1])) - 1; i++) {
			GameObject clone = Instantiate (Case);
			clone.transform.parent = canvas.transform;
			Debug.Log (str [id]);
			clone.GetComponent<Text> ().text = (str [id] [j] - 48).ToString();
			if ((str [id] [j] - 48) == 0) {
				clone.transform.GetChild (0).GetComponent<MeshRenderer> ().enabled = false;
				clone.GetComponent<Text> ().text = "";
			}
			block [i + 1] = clone; 
			j++;
		}
		GetComponent<Gameplay>().enabled = true;
	}

	// Update is called once per frame
	void Update () {

	}
}
