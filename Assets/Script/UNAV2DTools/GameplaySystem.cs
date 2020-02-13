using UnityEngine;
namespace UNAV2DTools.GameplaySystem
{
    public class GameplaySystem
    {
        public static Vector2 Axis
        {
            get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }

        public static bool JumpButton
        {
            get => Input.GetButtonDown("Jump");
        }

        public static void MovementTransform(Transform t, float moveSpeed, SpriteRenderer spr, bool flip, Animator anim)
            {

            t.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime * GameplaySystem.Axis.x);
            spr.flipX = flip;

            anim.SetFloat("axisX", Mathf.Abs(GameplaySystem.Axis.x));
           
        }
    }
}