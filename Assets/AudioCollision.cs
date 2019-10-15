using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollision : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void OnTriggerEnter(Collider food)
    {
        if (food.gameObject.tag == "Food")
        {
            audioSource.PlayOneShot(impact, 0.7f);
        }
    }
}