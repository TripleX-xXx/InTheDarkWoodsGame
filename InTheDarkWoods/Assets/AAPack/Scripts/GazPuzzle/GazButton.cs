using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazButton : MonoBehaviour ,IInteractive{

    [SerializeField]
    Gaz gaz;

    public void OnAction(GameObject player)
    {
        gaz.OnOff(false);
    }

    public PlayerCursor.Cursor OnFocused()
    {
        return PlayerCursor.Cursor.tool;
    }

}
