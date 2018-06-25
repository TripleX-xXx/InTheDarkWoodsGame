using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public RawImage[] endings;

    public void Endings()
    {
        DataStorage.Check();
        endings[0].enabled = DataStorage.Load(global::Endings.Ending1);
        endings[1].enabled = DataStorage.Load(global::Endings.Ending2);
        endings[2].enabled = DataStorage.Load(global::Endings.Ending3);
        endings[3].enabled = DataStorage.Load(global::Endings.Ending4);
    }

	public void PlayGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

    public void Reset()
    {
        DataStorage.Delete();
        Endings();
    }

    public void Exit()
	{
		Debug.Log ("Quit");
		Application.Quit ();
	}
}