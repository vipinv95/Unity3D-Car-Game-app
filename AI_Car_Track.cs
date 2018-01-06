using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Car_Track : MonoBehaviour {
	public Vector3 [] trackCoord = new Vector3 [60];
	public GameObject WaypointTarget;

	// Use this for initialization
	void Start () {
		trackCoord[0] = new Vector3(1.309875f,7.510456f,182.1375f);
		trackCoord[1] = new Vector3(-4.9f,7f,169.9f);
		trackCoord[2] = new Vector3(-9.3f,6.63f,159.77f);
		trackCoord[3] = new Vector3(-17.88f,5.93f,142.79f);
		trackCoord[4] = new Vector3(-23.1f,5.52f,134.08f);
		trackCoord[5] = new Vector3(-28.28f,5.1f,125.59f);
		trackCoord[6] = new Vector3(-31.53f,4.85f,121.55f);
		trackCoord[7] = new Vector3(-34.28f,4.63f,117.05f);
		trackCoord[8] = new Vector3(-38.59f,4.3f,112.34f);
		trackCoord[9] = new Vector3(-43.35f,3.94f,107.4f);
		trackCoord[10] = new Vector3(-50.39f,3.41f,100.87f);
		trackCoord[11] = new Vector3(-57.93f,2.85f,94.74f);
		trackCoord[12] = new Vector3(-65.08f,2.31f,87.7f);
		trackCoord[13] = new Vector3(-68.85f,1.98f,77.76f);
		trackCoord[14] = new Vector3(-65.56f,2.15f,70.14f);
		trackCoord[15] = new Vector3(-56.23f,2.75f,63.7f);
		trackCoord[16] = new Vector3(-48.99f,3.23f,60.22f);
		trackCoord[17] = new Vector3(-40f,3.83f,56.15f);
		trackCoord[18] = new Vector3(-34.92f,4.17f,54.86f);
		trackCoord[19] = new Vector3(-27.21f,4.68f,51.53f);
		trackCoord[20] = new Vector3(-2.86f,4.68f,43.12f);
		trackCoord[21] = new Vector3(12.03f,4.68f,37.09f);
		trackCoord[22] = new Vector3(22.36f,4.68f,32.56f);
		trackCoord[23] = new Vector3(35.02f,6.24f,26.18f);
		trackCoord[24] = new Vector3(44.75f,6.24f,19.14f);
		trackCoord[25] = new Vector3(54.61f,6.24f,11.78f);
		trackCoord[26] = new Vector3(64.93f,10.32f,-2.03f);
		trackCoord[27] = new Vector3(69.8f,10.32f,-28.83f);
		trackCoord[28] = new Vector3(72f,10.32f,-44.62f);
		trackCoord[29] = new Vector3(82.81f,10.32f,-53.83f);
		trackCoord[30] = new Vector3(100.81f,10.32f,-50.25f);
		trackCoord[31] = new Vector3(122.1f,10.32f,-35.53f);
		trackCoord[32] = new Vector3(142.9f,10.32f,-17.52f);
		trackCoord[33] = new Vector3(157.14f,10.32f,-1.62f);
		trackCoord[34] = new Vector3(184.34f,10.32f,32.23f);
		trackCoord[35] = new Vector3(196.09f,15.31f,50.24f);
		trackCoord[36] = new Vector3(202.84f,15.31f,61.99f);
		trackCoord[37] = new Vector3(211.23f,15.31f,80.5f);
		trackCoord[38] = new Vector3(205.13f,15.31f,93.85f);
		trackCoord[39] = new Vector3(188f,15.31f,95.2f);
		trackCoord[40] = new Vector3(156.5f,15.31f,88.9f);
		trackCoord[41] = new Vector3(129.5f,15.31f,85.8f);
		trackCoord[42] = new Vector3(103.7f,15.31f,90.7f);
		trackCoord[43] = new Vector3(92f,15.31f,106.8f);
		trackCoord[44] = new Vector3(83.13f,15.31f,138.09f);
		trackCoord[45] = new Vector3(77.45f,15.31f,185.12f);
		trackCoord[46] = new Vector3(72.97f,15.31f,205.35f);
		trackCoord[47] = new Vector3(66.53f,15.31f,222.31f);
		trackCoord[48] = new Vector3(56.92f,15.31f,236.55f);
		trackCoord[49] = new Vector3(46.2f,15.31f,242.6f);
		trackCoord[50] = new Vector3(37.5f,15.31f,239.6f);
		trackCoord[51] = new Vector3(20.1f,15.31f,219.5f);
		trackCoord[52] = new Vector3(9.99f,15.31f,201.06f);

		WaypointTarget.transform.position = trackCoord [0];



	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider collision) {
		if (collision.gameObject.tag == "AI1") {
			for (int i = 0;i<=52;i++) {
				if (WaypointTarget.transform.position == trackCoord [i]) {
					if (i == 52) {
						WaypointTarget.transform.position = trackCoord [0];
					} else {
						WaypointTarget.transform.position = trackCoord [i+1];
					}
					break;
				}
			}			
		}
	}
}
