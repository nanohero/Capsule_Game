using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour {

	public void TestLevel() {
        Application.LoadLevel("testlevel");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        Application.LoadLevel("Menu");
    }
	
	}

