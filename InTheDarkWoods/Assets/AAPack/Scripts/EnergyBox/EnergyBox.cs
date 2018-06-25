using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBox : MonoBehaviour {

    [SerializeField]
    float time = 0;

    [SerializeField]
    AudioSource soundDeath;

    [SerializeField]
    SwitchingSystem ss;
    
    [SerializeField]
    Door door;

    [SerializeField]
    int goodCount = 0;

    [SerializeField]
    int[] good;

    [SerializeField]
    int[] bad;

    private void Start()
    {
        if (goodCount < 1)
        {
            Win();
        }
    }

    private void Win()
    {
        door.OpenDoor(true);
    }

    private void Loss()
    {
        Kill();
    }

    public void Cut(int v)
    {
        foreach (int i in bad)
        {
            if (i == v)
            {
                Loss();
            }
        }

        foreach (int i in good)
        {
            if (i == v)
            {
                goodCount--;
                if (goodCount < 1)
                {
                    Win();
                }
            }
        }
    }

    public void Kill()
    {
        
            soundDeath.Play();
            StartCoroutine(Sleep());
    }

    IEnumerator Sleep()
    {
        yield return new WaitForSecondsRealtime(time);
        ss.GetComponent<SwitchingSystem>().Kill();
    }

}
