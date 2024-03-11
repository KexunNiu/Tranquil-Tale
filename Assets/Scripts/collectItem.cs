using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectItem : MonoBehaviour
{   private AudioSource soundEffect;

    private bool isPlayed = false;

    private void Start()
    {
        soundEffect = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!isPlayed)
            {
                isPlayed = true;
                soundEffect.Play();
            }
            Destroy(gameObject);
        }
    }
}
