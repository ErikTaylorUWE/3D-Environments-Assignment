using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Animator animator;
    public AudioClip chestOpen;
    public AudioClip chestClose;

    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        HideUI();

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            ShowUI();

        }

    }

    public void OpenChest()
    {
        animator.ResetTrigger("Close");
        animator.SetTrigger("Open");
        gameObject.GetComponent<AudioSource>().PlayOneShot(chestOpen);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //play animation

            animator.SetTrigger("Close");
            animator.ResetTrigger("Open");
            gameObject.GetComponent<AudioSource>().PlayOneShot(chestClose);
        }
    }

    public void HideUI()
    {
        ui.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ShowUI()
    {
        ui.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PressYes()
    {
        HideUI();
        OpenChest();

    }

    public void PressNo()
    {
        HideUI();

    }
}
