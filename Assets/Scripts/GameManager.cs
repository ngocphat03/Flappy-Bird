using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Player player;
    private Spawner spawner;
    // private Parallax parallax;
    public Text scoreText;
    public Text scoreClone;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject popupDie;
    public GameObject getReady;
    public GameObject profileButton;
    public GameObject profilePopup;
    public GameObject settingButton;
    public GameObject settingPopup;
    public int checkBtnSetting;
    public int score { get; private set; }
    public Text hightScoreText;
    public Text nowScoceText;
    public Text textInput;
    public GameObject inputField;
    public string nameNow;
    public Text playerOneName;
    public Text playerOneScore;
    public Text playerOneDate;
    public Text playerTwoName;
    public Text playerTwoScore;
    public Text playerTwoDate;
    public Text playerThreeName;
    public Text playerThreeScore;
    public Text playerThreeDate;

    private string FakePlayerOnePoint, FakePlayerOneName, FakePlayerOneDate; 
    private string FakePlayerTwoPoint, FakePlayerTwoName, FakePlayerTwoDate; 
    private string FakePlayerThreePoint, FakePlayerThreeName, FakePlayerThreeDate; 

    private void Awake()
    {
        settingPopup.SetActive(false);
        Application.targetFrameRate = 60;
        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();
        // parallax = FindObjectOfType<Parallax>();
        Pause();
        BackUp();
        checkBtnSetting = 2;
    }
    public void Play()
    {
        SoundController.instance.PlayThisSound("swoosh");
        score = 0;
        scoreClone.text = score.ToString();
        // textInput.text = "";
        scoreText.text = score.ToString();
        getReady.SetActive(false);
        playButton.SetActive(false);
        gameOver.SetActive(false);
        popupDie.SetActive(false);
        profileButton.SetActive(false);
        profilePopup.SetActive(false);
        settingButton.SetActive(false);
        settingPopup.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;
        checkBtnSetting = 0;
        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for (int i = 0; i < pipes.Length; i++) {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Setting()
    {
        settingPopup.SetActive(true);
    }
    public void CloseSetting()
    {
        settingPopup.SetActive(false);
            checkBtnSetting++;
    }
    public void Profile()
    {
        profilePopup.SetActive(true);
    }
    public void CloseProfile()
    {
        profilePopup.SetActive(false);
    }
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
    public void GameOver()
    {   
        playButton.SetActive(true);
        gameOver.SetActive(true);
        popupDie.SetActive(true);
        profileButton.SetActive(true);
        settingButton.SetActive(true);
        Pause();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        scoreClone.text = score.ToString();
    }
    public void achievements()
    {   
        PlayerPrefs.SetInt("NowScoce", score);
        if(PlayerPrefs.GetInt("HighScore") < PlayerPrefs.GetInt("NowScoce"))
        //if(true)
        {
            nameNow = inputField.GetComponent<Text>().text;
            DateTime timeNow = DateTime.Now;
            string timeNowClone = timeNow.ToString();
            string point = score.ToString();
            PlayerPrefs.SetInt("HightScoce", score);

            //Sap xep lai bang diem
            PlayerPrefs.SetString("HighDateThree", PlayerPrefs.GetString("HighDateTwo"));
            PlayerPrefs.SetString("HighDateTwo", PlayerPrefs.GetString("HighDateOne"));
            PlayerPrefs.SetString("HighPointThree", PlayerPrefs.GetString("HighPointTwo"));
            PlayerPrefs.SetString("HighPointTwo", PlayerPrefs.GetString("HighPointOne"));
            PlayerPrefs.SetString("HighNameThree", PlayerPrefs.GetString("HighNameTwo"));
            PlayerPrefs.SetString("HighNameTwo", PlayerPrefs.GetString("HighNameOne"));
            PlayerPrefs.SetString ("HighPointOne", point);
            PlayerPrefs.SetString ("HighNameOne", nameNow);
            PlayerPrefs.SetString ("HighDateOne", timeNowClone);
            // //In ra man hinh
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
        popupDie.SetActive(false);
    }
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
