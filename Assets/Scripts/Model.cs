using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    //Cho chim co the bay
    private Rigidbody2D body;
    public float strength = 5F;
    private void Awake()
    {
        body = this.gameObject.GetComponent<Rigidbody2D>();
    }
    public void birdMove()
    {
        body.velocity = Vector2.up * strength;
    }
    
}
