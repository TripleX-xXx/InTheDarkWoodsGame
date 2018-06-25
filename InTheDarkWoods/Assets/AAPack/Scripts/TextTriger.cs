using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTriger : MonoBehaviour {

    [SerializeField]
    Text text;

    [SerializeField]
    float time;

    [SerializeField]
    bool repeat;

    private void Start()
    {
        text.enabled = false;    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Sleep());
            if (!repeat)
            {
                DestroyObject(this);
            }
        }
    }

    IEnumerator Sleep()
    {
        text.enabled = true;
        yield return new WaitForSecondsRealtime(time);
        text.enabled = false;
        
    }

}
