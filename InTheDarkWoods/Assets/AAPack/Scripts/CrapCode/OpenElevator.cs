using UnityEngine;

public class OpenElevator : MonoBehaviour {

    [SerializeField]
    CheckPoint[] checkPoints;

    [SerializeField]
    Door door;

    bool flag;
    public bool button = false;

	void Update () {
        flag = true;
        foreach (CheckPoint c in checkPoints)
        {
            if (!c.enter)
            {
                flag = false;
            }
        }
        if (flag && button)
        {
            door.OpenDoor(true);
        }
	}
}
