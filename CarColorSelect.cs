using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarColorSelect : MonoBehaviour {
	public GameObject colorSelected;
	public static GameObject car;
	Renderer [] rend;
	// Use this for initialization
	void Start () {
		car = GameObject.Find("Cars");
		for (int i = 0; i < car.transform.childCount; i++) {
			if (car.transform.GetChild (i).gameObject.activeInHierarchy) {
				rend = car.transform.GetChild (i).GetComponentsInChildren<Renderer> ();

			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ChangeColor() {
		bool flagif = false;
		int valj = -1;
		for (int i = 0; i < rend.Length; i++) {
			valj = -1;
			flagif = false;
			for (int j = 0; j < rend [i].materials.Length; j++) {
				if (rend [i].materials [j].name.Contains ("Body")) {
					flagif = true;
					valj = j;
					break;
				}
			}
			if (flagif) {
				if (colorSelected.name.Contains ("green")) {
					rend [i].materials [valj].color = Color.green;
				} else if (colorSelected.name.Contains ("orange")) {
					rend [i].materials [valj].color = new Color32(237,63,5,255);
				} else if (colorSelected.name.Contains ("white")) {
					rend [i].materials [valj].color = Color.white;
				} else if (colorSelected.name.Contains ("grey")) {
					rend [i].materials [valj].color = Color.grey;
				} else if (colorSelected.name.Contains ("yellow")) {
					rend [i].materials [valj].color = Color.yellow;
				} else if (colorSelected.name.Contains ("black")) {
					rend [i].materials [valj].color = Color.black;
				} else {
					print (colorSelected.name + "Error in selecting");
				}
			}
		}
	}
}
