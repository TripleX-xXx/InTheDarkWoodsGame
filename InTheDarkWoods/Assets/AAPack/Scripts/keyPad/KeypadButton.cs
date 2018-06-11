using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadButton : MonoBehaviour, IInteractive{

    [SerializeField]
    AudioSource clikSound;

    [SerializeField]
    KeypadScreen screen;

    [SerializeField]
    char znak = '*';

    [SerializeField]
    bool isEnter = false;

    [SerializeField]
    bool isClear = false;

    public void OnAction(GameObject player)
    {
        if (clikSound != null)
        {
            clikSound.Play();
        }

        if (isEnter)
        {
            screen.Enter();
        }
        else if (isClear)
        {
            screen.ClearScreen();
        }
        else
        {
            screen.Button(znak);
        }
    }

    public PlayerCursor.Cursor OnFocused()
    {
        return PlayerCursor.Cursor.hand;
    }
}
