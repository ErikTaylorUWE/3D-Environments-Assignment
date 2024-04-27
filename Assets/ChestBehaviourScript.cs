using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    public Animator animator;
    public AudioClip chestOpen;
    public AudioClip chestClose;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"){
            //play animation
            animator.ResetTrigger("Close");
            animator.SetTrigger("Open");
            gameObject.GetComponent<AudioSource>().PlayOneShot(chestOpen);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player"){
            //play animation
            animator.ResetTrigger("Open");
            animator.SetTrigger("Close");
            gameObject.GetComponent<AudioSource>().PlayOneShot(chestClose);
        }
    }
}
