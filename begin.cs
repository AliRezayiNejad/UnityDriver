using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class begin : MonoBehaviour
{
	public UnityStandardAssets.Vehicles.Car.CarUserControl game;
	public Text starterview;
	int i = 3;
	public Camera cam1, camstart,back_camera;
	//public AudioSource LevelMusic;

	// Use this for initialization
	void Start()
	{
		back_camera.enabled = false;
		cam1.enabled = false;
		camstart.enabled = true;

		//InvokeRepeating("shoro", 1f, 1f);
		Invoke("first", 3f);
		//InvokeRepeating("shoro", 1f, 1f);






	}
	void first()
	{
		cam1.enabled = true;
		back_camera.enabled = true;
		camstart.enabled = false;
		InvokeRepeating("shoro", 1f, 1f);

	}

	void shoro()
	{
		if (i > 1)
		{
			i--;
			starterview.text = i + "";
		}
		else
		{
			starterview.enabled = false;
			game.enabled = true;
			CancelInvoke("shoro");
			//LevelMusic.Play ();
		}



	}


}
