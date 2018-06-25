using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWoter : MonoBehaviour {

    [SerializeField]
    AudioSource soundDeath;

    [SerializeField]
    SwitchingSystem ss;

    [SerializeField]
    AudioSource sound;

    [SerializeField]
    Transform start;

    [SerializeField]
    Transform end;

    [SerializeField]
    Transform platform;

    [SerializeField]
    Door exitDoor;

    [SerializeField]
    public float platformSpeed;

    Vector3 direction;
    Transform destinaction;
    bool stop = false;
    private bool flagEnd = false;
    float currendSpeed;
    private bool soundflag = true;

    void Start () {
        SetDestinaction(end);
        currendSpeed = platformSpeed;
    }

    public void SetFlagEnd(bool v)
    {
        flagEnd = v;
        if (v)
        {
            sound.Stop();
        }
        else
        {
            sound.Play();
        }
    }

    public float Pressure()
    {
        float d = Mathf.Abs(end.position.y - start.position.y);
        float c = Mathf.Abs(platform.position.y - start.position.y);
        return c / d;
    }

	void FixedUpdate () {
        if (!flagEnd)
        {
            if (Vector3.Distance(platform.transform.position, destinaction.position) >= currendSpeed * Time.fixedDeltaTime)
            {
                platform.SetPositionAndRotation((platform.position + direction * currendSpeed * Time.fixedDeltaTime), platform.rotation);
            }
            else
            {
                if (stop)
                {
                    //co robić kiedy woda opadnie
                    exitDoor.interable = true;
                    exitDoor.OpenDoor(true);
                }
                else
                {
                    Stop(true);
                    ss.GetComponent<SwitchingSystem>().Kill();
                }
                flagEnd = true;
            }
            if (soundflag)
            {
                if (Pressure() > 0.75f)
                {
                    soundflag = false;
                    soundDeath.Play();
                }
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
            sound.Stop();
            soundDeath.Stop();
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
