using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
  public static AudioManager Instance;
    public Audio_Data data;
    public GameObject BGMusic;
    public bool _BGMusicOn;

    [Tooltip("soundOn is used to toggle sound on/off from the Inspector")]
    public bool soundOn;
    private void Start()
    {
        if (Instance == null)
            Instance = this;
        BgMusic();

    }
    void BgMusic()
    {
        if (_BGMusicOn)
        {
            BGMusic.SetActive(true);
        }
    }
    public void Blade(Vector3 Blade)
    {
        if(soundOn)
        {
            AudioSource.PlayClipAtPoint(data.Blade, Blade);
        }
    }    
    public void Fuit(Vector3 fruit)
    {
        if (soundOn)
        {
            AudioSource.PlayClipAtPoint(data.Fruit, fruit);
        }
    }    
    public void Lose(Vector3 Lose)
    {
        if (_BGMusicOn)
        {
            AudioSource.PlayClipAtPoint(data.Bomb, Lose);
        }
    }    
    public void Button(Vector3 button)
    {
        if (soundOn)
        {
            AudioSource.PlayClipAtPoint(data.Button, button);
        }
    }    

}
