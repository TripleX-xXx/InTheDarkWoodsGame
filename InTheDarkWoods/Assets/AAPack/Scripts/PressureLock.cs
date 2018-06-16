using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureLock : MonoBehaviour {

    [SerializeField]
    MoveWoter woter;

    [SerializeField]
    Transform arrow;

    private void Set(float f)
    {
        arrow.eulerAngles =new Vector3(160 / f- 150, 0, 90);
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(woter.Pressure());
        Set(woter.Pressure());
	}
}
