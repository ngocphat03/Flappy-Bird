using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
interface IController
{
    public void ChangeScene();
    public void Setting();
	public void CloseSetting();
	public void Profile();
	public void CloseProfile();
	public void Facebook();
	public void Instagram();
	public void Tiktok();
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
//Show and hide button (UI-Screen & UI-Screen Popup) when we click
	public GameObject profileButton, profilePopup, settingButton, settingPopup;
    public void Setting()
    {
        settingPopup.SetActive(true);

    }
    public void CloseSetting()
    {
        settingPopup.SetActive(false);
    }
    public void Profile()
    {
        profilePopup.SetActive(true);
    }
    public void CloseProfile()
    {
        profilePopup.SetActive(false);

    }
//Cho em xin in4 :333
    public void Facebook()
    {
        Application.OpenURL("https://www.facebook.com/ngonngocphat");
    }
    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/mrfatttttt");
    }
    public void Tiktok()
    {
        Application.OpenURL("https://www.tiktok.com/@nnp1109");
    }
//Choi di! Khong nghien dau. Uy tin ma :333
    private Player player;
    float startTime = 1;
    public void Play()
    {
        SoundController.instance.PlayThisSound("swoosh");
        player.enabled = true;
        Time.timeScale = startTime;
        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for (int i = 0; i < pipes.Length; i++) {
            Destroy(pipes[i].gameObject);
        }
        PrintScore();
		FindObjectOfType<Model>().Achievements();
		FindObjectOfType<View>().ResetScreen();
    }
//Ngu dong thoi gian
    float pauseTime = 0;
    public void Pause()
    {
        Time.timeScale = pauseTime;
        player.enabled = false;
    }
//Nuoc mat em roi, tro choi ket thuc
    public void GameOver()
    {    
        Pause();
    }
//Chu quan tinh tien!!!
    public Text scoreText;
    public Text scoreClone;
    public int score { get; private set; }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        scoreClone.text = score.ToString();
    }
//Lay diem tu man hinh
    public void PrintScore()
    {
        scoreText.text = score.ToString();
        scoreClone.text = score.ToString();
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
//Cho chim bay len roi ha xuong
    private int directionMove = 1;
    private Vector3 movement;
    public Vector3 direction;
    public void BirdAutomaticallyMove()
    {
        movement.y += directionMove * (Time.deltaTime / 2);
        transform.position = movement;
        if(movement.y > 0.3 || movement.y < -1)
        {
            directionMove *= -1;
        }
    }
}
