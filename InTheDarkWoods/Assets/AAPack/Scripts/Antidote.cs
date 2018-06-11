using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antidote : MonoBehaviour ,IInteractive{

    [SerializeField]
    AudioSource drinkingSound;

    public void OnAction(GameObject player)
    {
        if (drinkingSound != null) drinkingSound.Play();
        DestroyObject(this);
    }

    public PlayerCursor.Cursor OnFocused()
    {
        return PlayerCursor.Cursor.hand;
    }

}
