using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrap : MonoBehaviour {

    [SerializeField]
    private Door door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            door.OpenDoor(false);
            door.locked = true;
            DestroyObject(gameObject);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }

}
