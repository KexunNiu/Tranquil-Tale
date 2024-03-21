using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectItem : MonoBehaviour
{   private AudioSource soundEffect;
    private Animator animator;

    private bool isPlayed = false;

    private void Start()
    {
        soundEffect = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            if (!isPlayed)
            {
                isPlayed = true;
                soundEffect.Play();
                animator.SetBool("Collected", true);
                PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();

                if (player != null && gameObject.CompareTag("Pineapple"))
                {
                    player.UpdateHealth(1);
                }

                if (player != null && gameObject.CompareTag("Banana"))
                {
                    player.UpdateSpeed(2);
                }

                if (player != null && gameObject.CompareTag("Apple"))
                {
                    player.UpdateJump(2);
                }


                // if (player != null)
                // {
                //     player.UpdateHealth(1);
                // }
            }
            Destroy(gameObject, soundEffect.clip.length);
        }
    }
}
