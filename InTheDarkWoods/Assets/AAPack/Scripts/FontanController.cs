using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FontanController : MonoBehaviour {

    [SerializeField]
    GameObject stop;

    [SerializeField]
    GameObject play;

    EllipsoidParticleEmitter particle;

    private void Start()
    {
        particle = gameObject.GetComponent<EllipsoidParticleEmitter>();
    }

    void Update () {
		if(!stop.activeSelf && play.activeSelf)
        {
            particle.emit = true;
        }
        else
        {
            particle.emit = false;
        }
	}
}
