using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MonoBehaviour {      



    public AudioMixer audioMIxer;
    Resolution[] resolutions;// pravljenje niza za dodavanje rezolucija
    public TMP_Dropdown resolutionDropdown;//dodavanje TotalMesh elemenata TMP_  i gore import paketa using TMPro
    
    void Start (){

        resolutions= Screen.resolutions;

        resolutionDropdown.ClearOptions();// brisanje opcija iz dropdown menija

        List<string> options= new List<string>(); // pravljenje liste  stringova koji ce dobijati vrednosti iz niza
        // Petlja za popunjavanje liste nizova
        int currentResolutionIndex = 0;
        for(int i=0; i< resolutions.Length; i++){

            string option =resolutions[i].width +" X " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width==Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }

        }
        resolutionDropdown.AddOptions(options);// Dodavanje u dropdow meni opcije iz liste nizova
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
        }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
        
	public void SetVolume(float volume)
    {
        audioMIxer.SetFloat("volume", volume);
       // Debug.Log(volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFullScreen) {

        Screen.fullScreen = isFullScreen;


    }
}
