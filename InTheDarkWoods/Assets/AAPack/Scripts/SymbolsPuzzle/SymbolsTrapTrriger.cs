using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolsTrapTrriger : MonoBehaviour {

    [SerializeField]
    private Door door;

    [SerializeField]
    private FlameController trap;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            door.OpenDoor(false);
            door.locked = true;
            trap.Run();
            DestroyObject(gameObject);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }
}
