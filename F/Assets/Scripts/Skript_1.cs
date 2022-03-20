using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skript_1 : MonoBehaviour
{
	public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene(Menu_1);
	}
	public void Exit()
	{
		Application.Quit();
	}

}
