using UnityEngine;
using UnityEngine.UI;
interface IView
{
	public void ResetScreen();
	public void ShowScreen();
	public void ShowAchievements();
}
public class View : Controller, IView
{
        public GameObject getReady, playButton, gameOver, popupDie;
    public Text playerOneName, playerOneScore, playerOneDate, playerTwoName, playerTwoScore, playerTwoDate, playerThreeName, playerThreeScore, playerThreeDate; 	
	public void ResetScreen()
	{
        getReady.SetActive(false);
        playButton.SetActive(false);
        gameOver.SetActive(false);
        popupDie.SetActive(false);
        settingButton.SetActive(false);
        settingPopup.SetActive(false);
        profileButton.SetActive(false);
        profilePopup.SetActive(false);
	}
	public void ShowScreen()
	{
        playButton.SetActive(true);
        gameOver.SetActive(true);
        popupDie.SetActive(true);
        profileButton.SetActive(true);
        settingButton.SetActive(true);
        Pause();
	}
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
}