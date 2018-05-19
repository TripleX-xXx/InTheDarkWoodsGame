using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Symbol : MonoBehaviour , IInteractive {

    [SerializeField]
    SymbolsPuzzle puzzle;

    [SerializeField]
    Image symbol;

    public PlayerCursor.Cursor OnFocused()
    {
        return PlayerCursor.Cursor.hand;
    }

    public void OnAction(GameObject player)
    {
        symbol.enabled = !symbol.enabled;
        puzzle.Check();
    }

    public bool Check()
    {
        return symbol.enabled;
    }

}
