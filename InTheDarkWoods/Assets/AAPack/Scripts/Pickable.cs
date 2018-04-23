using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour, IInteractive {

    [SerializeField]
    public string id = "";

    public void OnAction(GameObject player)
    {
        player.GetComponent<Inventory>().AddItem(this);
    }

    public PlayerCursor.Cursor OnFocused()
    {
        return PlayerCursor.Cursor.hand;
    }

    public string GetId()
    {
        return id;
    }

}
