using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antidote : MonoBehaviour ,IInteractive{

    [SerializeField]
    EndingsController ec;

    [SerializeField]
    AudioSource drinkingSound;

    public void OnAction(GameObject player)
    {
        if (drinkingSound != null) drinkingSound.Play();
        ec.poison = false;
        DestroyObject(gameObject);
    }

    public PlayerCursor.Cursor OnFocused()
    {
        return PlayerCursor.Cursor.hand;
    }

}
