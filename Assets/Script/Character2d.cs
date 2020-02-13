using System.Collections;
using System.Collections.Generic;
using UNAV2DTools.GameplaySystem;
using UnityEngine;

public class Character2d : MonoBehaviour
{
    [SerializeField, Range(0.1f, 7f)]
   protected float moveSpeed = 4f;

    [SerializeField, Range(0.1f, 10f)]
    protected float jumpForce = 7f;

    protected SpriteRenderer spr;
    protected Animator anim;
    protected Rigidbody2D rb2d;

    [SerializeField]
    protected Color rayColor = Color.magenta;

    [SerializeField, Range(0.1f, 5f)]
    protected float rayDistance = 1.7f;

    [SerializeField]
    protected LayerMask groundLayer;

    //protected unicamente puede acceder por medio de la herencia


    protected void Awake()
    {
        spr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }


    protected bool FlipSprite
    {
        get => GameplaySystem.Axis.x > 0 ? false : GameplaySystem.Axis.x < 0 ? true : spr.flipX;
    }

    protected bool Grounding
    {
        get => Physics2D.Raycast(transform.position, Vector2.down, rayDistance, groundLayer);
    }

    protected void OnDrawGizmosSelected()
    {
        Gizmos.color = rayColor;
        Gizmos.DrawRay(transform.position, Vector2.down * rayDistance);
    }
}
