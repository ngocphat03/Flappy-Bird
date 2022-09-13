using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Model : MonoBehaviour
{
    private Spawner spawner;

//Chim thuc tinh - san sang doi mat voi cai chet diii
    private void Awake()
    {
        Application.targetFrameRate = 60;
        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();
        Pause();
        BackUp();
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
        ResetScreen();
        PrintScore();
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
        ShowScreen();   
        Pause();
    }
//Reset UI-Screen when we died
    public GameObject getReady;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject popupDie;
    public GameObject profileButton;
    public GameObject profilePopup;
    public GameObject settingButton;
    public GameObject settingPopup;

    public void ResetScreen()
    {
        score = 0;
        getReady.SetActive(false);
        playButton.SetActive(false);
        gameOver.SetActive(false);
        popupDie.SetActive(false);
        settingButton.SetActive(false);
        settingPopup.SetActive(false);
        profileButton.SetActive(false);
        profilePopup.SetActive(false);
    }
//Show UI-Screen Popup when we died
    public void ShowScreen()
    {
        playButton.SetActive(true);
        gameOver.SetActive(true);
        popupDie.SetActive(true);
        profileButton.SetActive(true);
        settingButton.SetActive(true);
    }
//Show and hide button (UI-Screen & UI-Screen Popup) when we click
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
//Luu diem vao bo nho//

    public GameObject inputField;
    public string nameNow;
    public Text playerOneName, playerOneScore, playerOneDate;
    public Text playerTwoName, playerTwoScore, playerTwoDate;
    public Text playerThreeName, playerThreeScore, playerThreeDate;

    private string FakePlayerOnePoint, FakePlayerOneName, FakePlayerOneDate; 
    private string FakePlayerTwoPoint, FakePlayerTwoName, FakePlayerTwoDate; 
    private string FakePlayerThreePoint, FakePlayerThreeName, FakePlayerThreeDate; 
    public void achievements()
    {   
        PlayerPrefs.SetInt("NowScoce", score);
        //if(PlayerPrefs.GetInt("HighScore") < PlayerPrefs.GetInt("NowScoce"))
        if(true)
        {
            PrepareAchievements();
            SortAchievements();
            ShowAchievements();
        } 
        popupDie.SetActive(false);
    }
    //Chuan bi thu tuc cho bang diem
        public void PrepareAchievements()
        {
            nameNow = inputField.GetComponent<Text>().text;
            PlayerPrefs.SetInt("HightScoce", score);
        }
    //Sap xep lai bang diem
        public void SortAchievements()
        {
            DateTime timeNow = DateTime.Now;
            string timeNowClone = timeNow.ToString();
            string point = score.ToString();
            PlayerPrefs.SetString("HighDateThree", PlayerPrefs.GetString("HighDateTwo"));
            PlayerPrefs.SetString("HighDateTwo", PlayerPrefs.GetString("HighDateOne"));
            PlayerPrefs.SetString("HighPointThree", PlayerPrefs.GetString("HighPointTwo"));
            PlayerPrefs.SetString("HighPointTwo", PlayerPrefs.GetString("HighPointOne"));
            PlayerPrefs.SetString("HighNameThree", PlayerPrefs.GetString("HighNameTwo"));
            PlayerPrefs.SetString("HighNameTwo", PlayerPrefs.GetString("HighNameOne"));
            PlayerPrefs.SetString ("HighPointOne", point);
            PlayerPrefs.SetString ("HighNameOne", nameNow);
            PlayerPrefs.SetString ("HighDateOne", timeNowClone);
        }
    //In ra man hinh bang diem
        public void ShowAchievements()
        {
            playerOneName.text = PlayerPrefs.GetString("HighNameOne");
            playerOneScore.text = PlayerPrefs.GetString("HighPointOne");
            playerOneDate.text = PlayerPrefs.GetString("HighDateOne");

            playerTwoName.text = PlayerPrefs.GetString("HighNameTwo");
            playerTwoScore.text = PlayerPrefs.GetString("HighPointTwo");
            playerTwoDate.text = PlayerPrefs.GetString("HighDateTwo");

            playerThreeName.text = PlayerPrefs.GetString("HighNameThree");
            playerThreeScore.text = PlayerPrefs.GetString("HighPointThree");
            playerThreeDate.text = PlayerPrefs.GetString("HighDateThree");
        }
    //Backup du lieu tu lan choi gan nhat
        public void BackUp()
        {
            playerOneName.text = PlayerPrefs.GetString("HighNameOne");
            playerOneScore.text = PlayerPrefs.GetString("HighPointOne");
            playerOneDate.text = PlayerPrefs.GetString("HighDateOne");

            playerTwoName.text = PlayerPrefs.GetString("HighNameTwo");
            playerTwoScore.text = PlayerPrefs.GetString("HighPointTwo");
            playerTwoDate.text = PlayerPrefs.GetString("HighDateTwo");

            playerThreeName.text = PlayerPrefs.GetString("HighNameThree");
            playerThreeScore.text = PlayerPrefs.GetString("HighPointThree");
            playerThreeDate.text = PlayerPrefs.GetString("HighDateThree");
        }
}