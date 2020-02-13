using System.Collections;
using System.Collections.Generic;
using UNAV2DTools.GameplaySystem;
using UnityEngine;

public class Player : Character2d
{
  
    void Update()
    {
        GameplaySystem.MovementTransform(transform, moveSpeed, spr, FlipSprite, anim);

        if(GameplaySystem.JumpButton)
        {
            //salto
            if(Grounding)
            {
                rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                anim.SetTrigger("jump");

            }
        }
        anim.SetBool("ground", Grounding);
    }


    
}
