using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    [SerializeField]
    PuzzleLamp pl;

    public bool enter = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            enter = true;
            pl.IsDone(true);
        }
    }

}
