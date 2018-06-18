using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class SymbolsPuzzle : MonoBehaviour {

    [SerializeField]
    Symbol[] symbolsOn;

    [SerializeField]
    Symbol[] symbolsOff;

    [SerializeField]
    Door door;

    [SerializeField]
    FlameController trap;

    private bool flag;

    public void Check()
    {
        flag = true;
        foreach (Symbol s in symbolsOn)
        {
            if(!s.Check()) flag = false;
        }
        foreach (Symbol s in symbolsOff)
        {
            if (s.Check()) flag = false;
        }
        if (flag)
        {
            door.OpenDoor(true);
            door.locked = false;
            trap.Stop();
        }
    }


}
