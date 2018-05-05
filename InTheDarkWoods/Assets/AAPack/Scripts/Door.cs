using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour , IInteractive{

    [SerializeField]
    Animator animator;

    [SerializeField]
    AudioSource openSound;

    [SerializeField]
    AudioSource closeSound;

    [SerializeField]
    AudioSource lockedSound;

    [SerializeField]
    AudioSource OpenLockedSound;

    [SerializeField]
    bool interable = true;

    [SerializeField]
    bool isOpen = false;

    public bool locked = false;
    public string acceptableId;


    public void OnAction(GameObject player)
    {
        if (interable)
        {
            if (locked)
            {
                if (player.GetComponent<Inventory>().CheckItem() == acceptableId)
                {
                    locked = !locked;
                    if(OpenLockedSound != null) OpenLockedSound.Play();
                }
                else
                {
                    if(lockedSound != null) lockedSound.Play();
                }
            }
            else
            {
                if (isOpen)
                {
                    animator.SetTrigger("Close");
                    if (closeSound != null) closeSound.Play();
                }
                else
                {
                    animator.SetTrigger("Open");
                    if(openSound != null) openSound.Play();
                }
                isOpen = !isOpen;
            }
        }
    }

    public PlayerCursor.Cursor OnFocused()
    {
        if (interable)
        {
            return PlayerCursor.Cursor.hand;
        }
        else
        {
            return PlayerCursor.Cursor.none;
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
