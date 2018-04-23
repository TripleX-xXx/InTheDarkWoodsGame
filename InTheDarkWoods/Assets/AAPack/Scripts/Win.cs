using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

    [SerializeField]
    MoveWoter woter;

    [SerializeField]
    GameObject[] pipes;
    bool flag;

	void Start () {
        flag = true;
    }

	void Update () {
        flag = true;
        foreach (GameObject go in pipes)
        {
            if (!go.activeSelf)
            {
                flag = false;
            }
        }
        if (flag)
        {
            Debug.Log("Win");
            woter.Stop(true);
        }
	}
}
