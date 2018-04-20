using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePuzzle : MonoBehaviour, IInteractive {

    [SerializeField]
    GameObject pipe;

    [SerializeField]
    GameObject pipeGost;

    [SerializeField]
    public string acceptableId;

    public void OnAction(GameObject player)
    {
        if(player.GetComponent<Inventory>().CheckItem()==acceptableId)
        {
            player.GetComponent<Inventory>().UseItem();
            pipe.SetActive(!pipe.activeSelf);
            pipeGost.SetActive(!pipeGost.activeSelf);
        }
    }

    public PlayerCursor.Cursor OnFocused()
    {
        return PlayerCursor.Cursor.tool;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
