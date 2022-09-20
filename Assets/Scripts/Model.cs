using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

interface IModel
{
    public void Achievements();
    public void PrepareAchievements();
    public void SortAchievements();
}
public class Model : MonoBehaviour, IModel
{
//Luu diem vao bo nho//
    public GameObject inputField;
    public string nameNow;
    public int score;

//Kiem tra xem co phai diem cao nhat khong
    public void Achievements()
    {   
        PlayerPrefs.SetInt("NowScoce", score);
        if(PlayerPrefs.GetInt("HighScore") <= PlayerPrefs.GetInt("NowScoce"))
        //if(true)
        {
            PrepareAchievements();
            SortAchievements();
            // ShowAchievements();
        } 
        // popupDie.SetActive(false);
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
}