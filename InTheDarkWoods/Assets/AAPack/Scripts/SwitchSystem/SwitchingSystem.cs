using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchingSystem : MonoBehaviour {

    [SerializeField]
    Animator animator;

    [SerializeField]
    Animator animatorText;

    [SerializeField]
    Animator animatorDead;

    [SerializeField]
    Transform secondHero;

    [SerializeField]
    Image justin;

    [SerializeField]
    Image sara;

    public bool active = true;

    private bool isSara;
    private bool sataIsDead;
    private bool justinIsDead;

    private void Start()
    {
        isSara = false;
        sataIsDead = false;
        justinIsDead = false;
        sara.enabled = false;
        justin.enabled = true;
}

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E) && active)
        {
            animator.SetTrigger("Fade_Out");
        }
        else if (Input.GetKeyDown(KeyCode.E) && !active)
        {
            animatorText.SetTrigger("Info");
        }
    }

    public void Switch()
    {
        if(isSara && !justinIsDead)
        {
            Go();
        }
        else if (!isSara && !sataIsDead)
        {
            Go();
        }
        else
        {
            animatorDead.SetTrigger("Info");
        }
    }

    public void Kill()
    {
        if(isSara)
        {
            sataIsDead = true;
            //endGame
            animator.SetTrigger("Fade_Out");
        }
        else
        {
            justinIsDead = true;
            animator.SetTrigger("Fade_Out");
        }
    }

    private void Go()
    {
        isSara = !isSara;
        sara.enabled = !sara.enabled;
        justin.enabled = !justin.enabled;
        Vector3 tempPosition = secondHero.position;
        Quaternion tempRotation = secondHero.rotation;
        GetComponent<Inventory>().RemoveItem();
        secondHero.SetPositionAndRotation(transform.position, transform.rotation);
        gameObject.GetComponent<Transform>().SetPositionAndRotation(tempPosition, tempRotation);

    }
}
