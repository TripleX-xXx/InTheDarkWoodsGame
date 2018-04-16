using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractive {

    PlayerCursor.Cursor OnFocused();
    void OnAction(GameObject player);

}
