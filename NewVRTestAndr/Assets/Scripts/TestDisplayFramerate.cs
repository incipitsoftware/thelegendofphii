using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestDisplayFramerate : MonoBehaviour {

	public bool resolutionResizing = false;
	public float faleFrameMax = 9.9f;
	public int faleTimeMax = 100;

	public float refreshTimer = 0.5f;

	private float temp;
	private int tempFaleTime;
	private ArrayList list;

	private float resHeight;
	private float resWidth;

	void Start()
	{
		temp = refreshTimer;
		tempFaleTime = faleTimeMax;

		Resolution resolution = Screen.currentResolution;
		resHeight = resolution.height;
		resWidth = resolution.width;

		this.GetComponent<Text> ().text = "";
	}

	// Update is called once per frame
	void Update () {
		refreshTimer -= Time.deltaTime;
		float framerate = (1.0f / Time.deltaTime);
		//each time the framerate is under a defined value,
		//count up. if a defined value is reached, reset resolution
		if (refreshTimer <= 0) {
			if (framerate <= faleFrameMax)
				faleTimeMax--;
			
			//this.GetComponent<Text> ().text = "Framerate: " + (1.0f / Time.deltaTime).ToString () +
			//" - noch " + faleTimeMax.ToString () + " mal bis RESZ \n" +
			//"width: " + resWidth.ToString () + " heigth: " + resHeight.ToString ();
			
			refreshTimer = temp;
		}

		if (faleTimeMax <= 0 && resolutionResizing) {
			Screen.SetResolution ((int)(resWidth /= 1.25f), (int)(resHeight /= 1.25f), true);
			faleTimeMax = tempFaleTime;
		}
	}
}
