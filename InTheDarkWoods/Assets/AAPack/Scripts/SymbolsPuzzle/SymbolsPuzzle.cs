using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class SymbolsPuzzle : MonoBehaviour {

    [SerializeField]
    Symbol[] symbolsOn;

    [SerializeField]
    Symbol[] symbolsOff;

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
            Debug.Log("Open");
        }
    }


}
