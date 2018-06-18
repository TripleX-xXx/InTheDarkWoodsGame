using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrapPipes : MonoBehaviour {

    [SerializeField]
    Door door;

    [SerializeField]
    MoveWoter woter;

    [SerializeField]
    FontanController[] fontains;

    private void Start()
    {
        door.interable = true;
        woter.SetFlagEnd(true);

        foreach (FontanController f in fontains)
        {
            f.OnOff(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            door.interable = false;
            door.OpenDoor(false);
            woter.SetFlagEnd(false);

            foreach (FontanController f in fontains)
            {
                f.OnOff(true);
            }
            DestroyObject(gameObject);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }
}
