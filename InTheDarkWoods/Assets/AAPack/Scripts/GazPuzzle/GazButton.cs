using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazButton : MonoBehaviour, IInteractive {

    [SerializeField]
    Gaz gaz;

    [SerializeField]
    PuzzleLamp pl;

    [SerializeField]
    OpenElevator openElevator;

    public void OnAction(GameObject player)
    {
        gaz.OnOff(false);
        openElevator.button = true;
        pl.IsDone(true);
    }

    public PlayerCursor.Cursor OnFocused()
    {
        return PlayerCursor.Cursor.tool;
    }

}
