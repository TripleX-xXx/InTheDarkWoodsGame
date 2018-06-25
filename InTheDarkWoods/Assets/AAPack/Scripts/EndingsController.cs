using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingsController : MonoBehaviour {

    [SerializeField]
    RawImage ending1;
    [SerializeField]
    RawImage ending2;
    [SerializeField]
    RawImage ending3;
    [SerializeField]
    RawImage ending4;

    public bool poison;
    public bool GasOn;
    public bool justinDead;
    public bool saraDead;
    public bool justinSave;
    public bool saraSave;

    private bool flag;

    private void Start()
    {
        poison = true;
        GasOn = true;
        justinDead = false;
        saraDead = false;
        flag = false;
        justinSave = false;
        saraSave = false;

    ending1.enabled = false;
        ending2.enabled = false;
        ending3.enabled = false;
        ending4.enabled = false;
    }

    public void Ending()
    {
        if (justinSave && saraSave && !poison)
        {
            DataStorage.Save(Endings.Ending4, true);
            ending4.enabled = true;
            flag = true;
        }
        else if (justinSave && saraSave && poison)
        {
            DataStorage.Save(Endings.Ending3, true);
            ending3.enabled = true;
            flag = true;
        }
        else if (saraSave && justinDead)
        {
            DataStorage.Save(Endings.Ending2, true);
            ending2.enabled = true;
            flag = true;
        }
        else if (saraSave && GasOn)
        {
            DataStorage.Save(Endings.Ending2, true);
            ending2.enabled = true;
            flag = true;
        }
        else if (saraDead && GasOn)
        {
            DataStorage.Save(Endings.Ending1, true);
            ending1.enabled = true;
            flag = true;
        }
        else if (justinDead && saraDead)
        {
            DataStorage.Save(Endings.Ending1, true);
            ending1.enabled = true;
        }
    }

    private void Update()
    {
        if (flag)
        {
            if (Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.Mouse0))
            {
                flag = false;
                SceneManager.LoadScene(0);
            }
        }
    }

}
