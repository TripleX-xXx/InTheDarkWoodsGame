using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenElevator : MonoBehaviour {

    [SerializeField]
    CheckPoint[] checkPoints;

    [SerializeField]
    Door door;

    bool flag;

	void Update () {
        flag = true;
        foreach (CheckPoint c in checkPoints)
        {
            if (!c.enter)
            {
                flag = false;
            }
        }
        if (flag)
        {
            door.OpenDoor(true);
        }
	}
}
