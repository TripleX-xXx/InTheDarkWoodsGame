using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    GameObject inventory;

    [SerializeField]
    Image image;

    private void Start()
    {
        image.enabled = false;
    }

    public void AddItem(GameObject item)
    {
        if (inventory != null)
        {
            RemoveItem();
        }

        inventory = item;
        inventory.SetActive(false);
        image.enabled = true;

    }

    public void RemoveItem()
    {
        inventory.transform.SetPositionAndRotation(transform.position, Quaternion.identity);
        inventory.SetActive(true);
        inventory = null;
        image.enabled = false;
    }



}
