using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

namespace LP
{ 
    public class SettingsMenu : MonoBehaviour
    {
       // public AudioMixer audioMixer;
        public void SetVolume(float vol)
        {
     //       audioMixer.SetFloat("Volume", vol);
        }
        public void SetQuality(int qualityIndex)
        {
      //      QualitySettings.SetQualityLevel(qualityIndex);
        }
    }

}