using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour, IInteractive {

    [SerializeField]
    TextMesh text;

    [SerializeField]
    char znak;

    [SerializeField]
    bool isEnter = false;

    [SerializeField]
    string kod;

    [SerializeField]
    Door door;


    public void OnAction(GameObject player)
    {
        if (!isEnter)
        {
            if (text.text.Length < 4)
            {
                text.text = text.text + znak;
            }
            else
            {
                text.text = "" + znak;
            }
        }
        else
        {
            if (text.text.Equals(kod))
            {
                door.OpenDoor(true);
            }
            else
            {
                text.text = "";
            }
        }
    }

    public PlayerCursor.Cursor OnFocused()
    {
        return PlayerCursor.Cursor.hand;
    }

}
