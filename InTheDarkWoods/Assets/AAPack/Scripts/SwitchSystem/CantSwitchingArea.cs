using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantSwitchingArea : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<SwitchingSystem>().active = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<SwitchingSystem>().active = true;
        }
    }
}
