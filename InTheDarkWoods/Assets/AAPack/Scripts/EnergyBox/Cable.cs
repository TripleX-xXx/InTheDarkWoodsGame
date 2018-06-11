using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour, IInteractive
{

    [SerializeField]
    EnergyBox box;

    [SerializeField]
    GameObject cable;

    [SerializeField]
    GameObject cableBreak;

    [SerializeField]
    int number;

    [SerializeField]
    string acceptableId;

    private bool flag = true;

    private void Start()
    {
        cableBreak.SetActive(false);
        cable.SetActive(true);
    }

    public void OnAction(GameObject player)
    {
        if (player.GetComponent<Inventory>().CheckItem() == acceptableId)
        {
            cableBreak.SetActive(true);
            cable.SetActive(false);
            if (flag)
            {
                box.Cut(number);
                flag = false;
            }
        }
    }

    public PlayerCursor.Cursor OnFocused()
    {
        return PlayerCursor.Cursor.tool;
    }
}
