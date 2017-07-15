using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private GameObject MainCam;
	private GameObject SubCam;

	void Start () {
		MainCam = GameObject.Find("MainCamera");
		SubCam = GameObject.Find("SubCamera");

		SubCam.SetActive(false);
	}

	void Update () {
		if(Input.GetKeyDown("space")){
			if(MainCam.activeSelf){
				MainCam.SetActive (false);
				SubCam.SetActive (true);
			}else{
				MainCam.SetActive (true);
				SubCam.SetActive (false);
			}
		}
	}

}
