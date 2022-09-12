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
//Cho mat dat co the di chuyen lien tuc
    // private MeshRenderer meshRenderer;
    // public float animationSpeed = 0.6f;

    // public void groundRun()
    // { 
    //     meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0); 
    // } 
//Xu li khi va cham
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle")) {
            // SoundController.instance.PlayThisSound("hit");
            // FindObjectOfType<GameManager>().GameOver();
        } else if (other.gameObject.CompareTag("Scoring")) {
            // SoundController.instance.PlayThisSound("point");
            // FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
    
}