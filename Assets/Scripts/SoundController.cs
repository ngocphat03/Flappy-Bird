using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    [SerializeField] Slider volumeMultiplier;
    public static SoundController instance;
    private void Awake()
    {
        instance = this;
    }
    public void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }
//Tang giam am luong tu thanh "Slide"
    public void ChangeVolume()
    {
        AudioListener.volume = volumeMultiplier.value;
        Save();
    }
//Ham choi nhac duoc goi
    public void PlayThisSound(string clipName)
    {
        AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot((AudioClip)Resources.Load("Sounds/" + clipName, typeof(AudioClip)));
    }
//Tai cuong do am luong
    private void Load()
    {
        volumeMultiplier.value = PlayerPrefs.GetFloat("musicVolume");
    }
//Luu cuong do am luong
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeMultiplier.value);
    }
}
