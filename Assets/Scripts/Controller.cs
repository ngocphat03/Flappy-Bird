using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
interface IController
{
    public void ChangeScene();
    public void PopupOn();
    public void PopupOff();
    public void SocialNetwork();
    public void Play();
    public void Pause();
    public void GameOver();
    public void IncreaseScore();
    public void PrintScore();
    public void GetSpriteRender();
    public void RepeatingAnimate();
    public void AnimateSprite();
    public void BirdAutomaticallyMove();
}
public class Controller : MonoBehaviour, IController
{    
//Chuyen qua phan choi chinh
    public void ChangeScene()
    {
        SceneManager.LoadScene("Start");
    }
    public void PopupOn()
    {

    }
    public void PopupOff()
    {

    }
    public void SocialNetwork()
    {

    }
    public void Play()
    {

    }
    public void Pause()
    {

    }
    public void GameOver()
    {

    }
    public void IncreaseScore()
    {

    }
    public void PrintScore()
    {

    }
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
    public void BirdAutomaticallyMove()
    {

    }
}
