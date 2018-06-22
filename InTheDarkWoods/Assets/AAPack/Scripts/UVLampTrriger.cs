using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVLampTrriger : MonoBehaviour {

    [SerializeField]
    private Door door;

    [SerializeField]
    Timer timer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            door.OpenDoor(false);
            door.locked = true;
            timer.OnOFF(true);
            DestroyObject(gameObject);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }
}
