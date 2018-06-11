using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadScreen : MonoBehaviour {

    [SerializeField]
    Door door;

    [SerializeField]
    Text screen;

    [SerializeField]
    string kod;

    [SerializeField]
    int maxLength = 0;

    private string currendKod = "";

    private void Start()
    {
        screen.text = "";
    }

    public void Button(char z)
    {
        if (maxLength < 1 || currendKod.Length < maxLength)
        {
            currendKod += "" + z;
        }
        else
        {
            currendKod = "" + z;
        }
        UpdateScreen();
    }

    public void Enter()
    {
        if (currendKod == kod)
        {
            Open();
        }
        ClearScreen();
    }

    public void ClearScreen()
    {
        currendKod = "";
        UpdateScreen();
    }

    private void UpdateScreen()
    {
        if (screen != null)
        {
            screen.text = currendKod;
        }
    }

    private void Open()
    {
        door.OpenDoor(true);
    }

}
