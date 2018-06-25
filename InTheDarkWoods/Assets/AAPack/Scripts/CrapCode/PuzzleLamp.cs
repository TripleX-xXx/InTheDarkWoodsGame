using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleLamp : MonoBehaviour {

    [SerializeField]
    Light red;

    [SerializeField]
    Light green;

    // Use this for initialization
    void Start () {
        IsDone(false);
	}

    public void IsDone(bool flag)
    {
        if (flag)
        {
            green.enabled = true;
            red.enabled = false;
        }
        else
        {
            green.enabled = false;
            red.enabled = true;
        }
    }

}
