using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCursor : MonoBehaviour {

    [SerializeField]
    Camera playerCamera;

    [SerializeField]
    Image[] cursors;

    [SerializeField]
    float length = 3f;

    public enum Cursor
    {
        none,
        dot,
        hand,
        tool
    };

    Cursor currentCursor = Cursor.none;

    void Update()
    {
        RaycastHit hit;
        Vector3 direction = playerCamera.transform.TransformDirection(Vector3.forward*length);
        Debug.DrawRay(playerCamera.transform.position, direction, Color.green,1f);
        if (Physics.Raycast(playerCamera.transform.position, direction, out hit, length))
        {
            if (hit.collider.CompareTag("Item"))
            {
                SetCursor(hit.collider.GetComponent<IInteractive>().OnFocused());
                if (Input.GetKeyDown(KeyCode.Mouse0))
                    hit.collider.GetComponent<IInteractive>().OnAction(gameObject);
            }
            else
            {
                SetCursor(Cursor.dot);
                if (Input.GetKeyDown(KeyCode.Mouse1))
                    GetComponent<Inventory>().RemoveItem();
            }

        }
        else
        {
            SetCursor(Cursor.dot);
            if (Input.GetKeyDown(KeyCode.Mouse1))
                GetComponent<Inventory>().RemoveItem();
        }
    }

    void SetCursor(Cursor cursor)
    {
        if (cursor != currentCursor)
        {
            currentCursor = cursor;
            foreach (Image i in cursors)
            {
                i.enabled = false;
            }
            cursors[(int)cursor].enabled = true;
        }
    }

}
