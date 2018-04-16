using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCursor : MonoBehaviour {

    [SerializeField]
    Camera camera;

    [SerializeField]
    Image[] cursors;

    public enum Cursor
    {
        none,
        dot,
        hand,
        tool
    };

    Cursor currentCursor = Cursor.none;

    void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 direction = camera.transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(camera.transform.position, direction, Color.green,2f);
        if (Physics.Raycast(camera.transform.position, direction, out hit, 2f))
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
