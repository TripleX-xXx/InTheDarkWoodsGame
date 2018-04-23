using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWoter : MonoBehaviour {

    [SerializeField]
    Transform start;

    [SerializeField]
    Transform end;

    [SerializeField]
    Transform platform;

    [SerializeField]
    public float platformSpeed;

    Vector3 direction;
    Transform destinaction;
    bool stop = false;
    float currendSpeed;

    void Start () {
        SetDestinaction(end);
        currendSpeed = platformSpeed;
    }
	
	void FixedUpdate () {

        if (Vector3.Distance(platform.transform.position, destinaction.position) >= currendSpeed * Time.fixedDeltaTime)
        {
            platform.SetPositionAndRotation((platform.position + direction * currendSpeed * Time.fixedDeltaTime), platform.rotation);
        }
        else
        {
            if (stop)
            {
                //co robić kiedy woda opadnie
                Debug.Log("Door is opened");
            }
            else
            {
                Debug.Log("Lose");
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(start.position, start.localScale);

        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(end.position, end.localScale);
    }

    void SetDestinaction(Transform dest)
    {
        destinaction = dest;
        direction = (destinaction.position - platform.transform.position).normalized;
    }

    public void Stop(bool stop)
    {
        this.stop = stop;
        if (stop)
        {
            currendSpeed = platformSpeed * 5;
            SetDestinaction(start);
        }
        else
        {
            currendSpeed = platformSpeed;
            SetDestinaction(end);
        }
    }

}
