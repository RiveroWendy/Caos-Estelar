using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Source")]
    [SerializeField] private AudioSource _musicSource;
    [SerializeField] private AudioSource _SfxSource;
    [Header("Audio Clip")]
    [SerializeField] private Sound[] _music;
    [SerializeField] private Sound[] _sfx;

    private void Awake()
    {
        //if(Instance == null)
        //{
        //    Instance = this;
        //    DontDestroyOnLoad(gameObject);
        //}
        //else
        //{
        //    Destroy(gameObject);
        //}
    }

    private void Start()
    {
       string nombreEscenaActiva = SceneManager.GetActiveScene().name;
       if(nombreEscenaActiva == "Menu" || nombreEscenaActiva=="Final") 
        {
            PlayMusic("Menu");
            PlaySFX("Menu");
        }
        else if(nombreEscenaActiva=="Level 1")
        {
            PlayMusic("LevelOne");
           
        }
        else if (nombreEscenaActiva == "Level 2")
        {
            PlayMusic("LevelTwo");

        }
    }
       
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(_music, x => x.name == name);

        if(s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            _musicSource.clip = s.clip;
            _musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(_sfx, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {

            _SfxSource.PlayOneShot(s.clip);
        }

    }
    

}
