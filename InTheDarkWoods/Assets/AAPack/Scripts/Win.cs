using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

    [SerializeField]
    MoveWoter woter;

    [SerializeField]
    GameObject[] pipes;
    bool flag;
    bool flagEnd;

	void Start () {
        flag = true;
        flagEnd = false;
    }

	void Update () {
        if (!flagEnd)
        {
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
                flagEnd = true;
                Debug.Log("Win");
                woter.Stop(true);
            }
        }
	}
}
