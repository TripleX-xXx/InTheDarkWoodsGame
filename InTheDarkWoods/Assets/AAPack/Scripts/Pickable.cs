using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour, IInteractive {

    public void OnAction(GameObject player)
    {
        player.GetComponent<Inventory>().AddItem(gameObject);
    }

    public PlayerCursor.Cursor OnFocused()
    {
        return PlayerCursor.Cursor.hand;
    }

}
