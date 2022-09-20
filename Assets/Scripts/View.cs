using UnityEngine;

//Interface for the view
public interface IBirdView
{

}

public class View : MonoBehaviour, IBirdView
{

}














/*
public class View : MonoBehaviour
{
//Lam cho chim vo canh
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public int spriteIndex;
    //Lay hieu ung
    public void GetSpriteRender()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    //Lap lai hieu ung vo canh
    public void RepeatingAnimate()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }
    //Lam hieu ung vo canh
    public void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length) {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
    }
//Cho chim bay len roi ha xuong
    private int directionMove = 1;
    private Vector3 movement;
    public Vector3 direction;
    public void MoveBirdTopAndBottom()
    {
        movement.y += directionMove * (Time.deltaTime / 2);
        transform.position = movement;
        if(movement.y > 0.3 || movement.y < -1)
        {
            directionMove *= -1;
        }
    }
}
*/