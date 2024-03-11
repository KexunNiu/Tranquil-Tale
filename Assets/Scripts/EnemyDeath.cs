using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private AudioSource soundEffect;
    
    [SerializeField] private LayerMask playerLayer;
    private bool isSoundPlaying = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        soundEffect = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f, playerLayer);

        if (hit.collider != null)
        {
            animator.SetTrigger("Death");

            if (!isSoundPlaying)
            {
                soundEffect.Play();
                isSoundPlaying = true;
            }
            Destroy(gameObject, 1f);
        }
    }
}
