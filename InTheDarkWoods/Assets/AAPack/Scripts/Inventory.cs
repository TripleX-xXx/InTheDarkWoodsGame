using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    Pickable inventory;

    [SerializeField]
    Transform hand;

    private void Start()
    {

    }

    public void AddItem(Pickable item)
    {
        if (inventory != null)
        {
            RemoveItem();
        }

        inventory = item;
        inventory.GetComponent<Rigidbody>().detectCollisions = false;
        inventory.GetComponent<Rigidbody>().useGravity = false;
        inventory.GetComponent<Rigidbody>().freezeRotation = true;
        inventory.GetComponent<Transform>().SetParent(hand);
        inventory.GetComponent<Transform>().localPosition = Vector3.zero;
        inventory.GetComponent<Transform>().localRotation = Quaternion.identity;

    }

    public void RemoveItem()
    {
        if (inventory != null)
        {
            inventory.GetComponent<Rigidbody>().detectCollisions = true;
            inventory.GetComponent<Rigidbody>().useGravity = true;
            inventory.GetComponent<Transform>().SetParent(null);
            inventory = null;
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
            Destroy(inventory.gameObject);
            inventory = null;
            return true;
        }
        else
        {
            return false;
        }
    }

}
