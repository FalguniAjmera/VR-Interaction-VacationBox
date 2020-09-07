using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	public void newScene(){
		Debug.Log("my method is called");
		SceneManager.LoadScene("00-FallingCoconut");
	}
}
