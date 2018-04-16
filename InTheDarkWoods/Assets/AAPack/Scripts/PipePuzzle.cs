using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePuzzle : MonoBehaviour, IInteractive {



    public void OnAction(GameObject player)
    {

    }

    public PlayerCursor.Cursor OnFocused()
    {
        return PlayerCursor.Cursor.tool;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
