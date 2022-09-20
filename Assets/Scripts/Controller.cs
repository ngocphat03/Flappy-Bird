using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public interface IBirdController
{

}

public class Controller : IBirdController
{

}

/*
public class Controller : MonoBehaviour
{
//Chuyen qua phan choi chinh
    public void ChangeScene()
    {
        SceneManager.LoadScene("Start");
    }
//Click play button
    public void PlayButton()
    {
        FindObjectOfType<Model>().Play();
    }
//Click setting button
    public void SettingButton()
    {
        FindObjectOfType<Model>().Setting();
    }
//Click close setting button
    public void CloseSettingButton()
    {
        FindObjectOfType<Model>().CloseSetting();
    }
//Click profile button
    public void ProfileButton()
    {
        FindObjectOfType<Model>().Profile();
    }
//Click close profile button
    public void CloseProfileButton()
    {
        FindObjectOfType<Model>().CloseProfile();
    }
//Click save button
    public void SaveButton()
    {
        FindObjectOfType<Model>().Achievements();
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
}
*/