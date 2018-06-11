using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FontanController : MonoBehaviour {

    [SerializeField]
    GameObject stop;

    [SerializeField]
    GameObject play;

    bool flag = false;

    EllipsoidParticleEmitter particle;

    private void Start()
    {
        particle = gameObject.GetComponent<EllipsoidParticleEmitter>();
    }

    void Update () {
        if (flag)
        {
            if (!stop.activeSelf && play.activeSelf)
            {
                particle.emit = true;
            }
            else
            {
                particle.emit = false;
            }
        }
        else
        {
            particle.emit = false;
        }
	}

    public void OnOff(bool f)
    {
        flag = f;
    }
}
