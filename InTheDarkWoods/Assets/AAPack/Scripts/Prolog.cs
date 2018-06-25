using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Prolog : MonoBehaviour {

    [SerializeField]
    RawImage[] images;

    [SerializeField]
    float speed;

    float time = 0;

	// Use this for initialization
	void Start () {
        foreach (RawImage i in images)
        {
            i.enabled = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.Mouse0))
        {
            time+=speed;
        }
        //time += Time.deltaTime;
        if ((int)(time/speed) < images.Length)
        {
            images[(int)(time / speed)].enabled = true;
        }
        else if (time >= images.Length + speed)
        {
            SceneManager.LoadScene(2);
        }
	}

}
