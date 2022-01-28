using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{

	public GameObject loadingMenu;

	// Start is called before the first frame update
	public void start_game()
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync("Sprint_Track");
		loadingMenu.SetActive(true);
	}

	public void menu()
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync("Menu_Scene");

	}
}
