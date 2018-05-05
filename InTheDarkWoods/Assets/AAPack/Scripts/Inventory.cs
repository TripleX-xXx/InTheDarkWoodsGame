using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    Pickable inventory;

    [SerializeField]
    Transform hand;

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
        inventory.GetComponent<Rigidbody>().detectCollisions = false;
        inventory.GetComponent<Rigidbody>().useGravity = false;
        inventory.GetComponent<Rigidbody>().freezeRotation = true;
        inventory.GetComponent<Transform>().SetParent(hand);
        inventory.GetComponent<Transform>().localPosition = Vector3.zero;
        inventory.GetComponent<Transform>().localRotation = Quaternion.identity;

        //inventory.gameObject.SetActive(false);
        image.enabled = true;

    }

    public void RemoveItem()
    {
        if (inventory != null)
        {
            inventory.GetComponent<Rigidbody>().detectCollisions = true;
            inventory.GetComponent<Rigidbody>().useGravity = true;
            inventory.GetComponent<Transform>().SetParent(null);
            //inventory.transform.SetPositionAndRotation(transform.position + transform.localRotation.eulerAngles.normalized, Quaternion.identity);
            //inventory.gameObject.SetActive(true);
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
            Destroy(inventory.gameObject);
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
