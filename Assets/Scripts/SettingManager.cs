using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class SettingManager : MonoBehaviour {

    public GameObject opUI;
    public Toggle ppToggle;
    public GameSettings gs;

    void Start () {
        opUI.SetActive(false);
    }

    public void OpenOptions()
    {
        opUI.SetActive(true);
        gs = new GameSettings();
    }

    public void CloseOptions()
    {
        opUI.SetActive(false);
    }


    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Endless()
    {
        SceneManager.LoadScene(2);
    }
}
