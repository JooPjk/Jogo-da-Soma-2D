using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
   
   public Slider volumeSlider;
   public AudioSource backgroundMusic;

   private void Start()
   {
    volumeSlider.onValueChanged.AddListener(ChangeVolume);
   }

    private void ChangeVolume(float volume)
    {
        backgroundMusic.volume = volume;
    }



}
