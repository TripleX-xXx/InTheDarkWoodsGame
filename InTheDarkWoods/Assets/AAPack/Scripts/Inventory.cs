using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    Pickable inventory;

    [SerializeField]
    Image image;

    private void Start()
    {
        image.enabled = false;
    }

    public void AddItem(Pickable item)
    {
        if (inventory != null)
        {
            RemoveItem();
        }

        inventory = item;
        inventory.gameObject.SetActive(false);
        image.enabled = true;

    }

    public void RemoveItem()
    {
        if (inventory != null)
        {
            inventory.transform.SetPositionAndRotation(transform.position + transform.localRotation.eulerAngles.normalized, Quaternion.identity);
            inventory.gameObject.SetActive(true);
            inventory = null;
            image.enabled = false;
        }
    }

    public string CheckItem()
    {
        if (inventory != null)
        {
            return inventory.GetId();
        }
        else
        {
            return null;
        }
    }

    public bool UseItem()
    {
        if(inventory!=null)
        {
            inventory = null;
            image.enabled = false;
            return true;
        }
        else
        {
            return false;
        }
    }

}
