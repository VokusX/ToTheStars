using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPause : MonoBehaviour {

	void Update () {
        AudioSource a = GetComponent<AudioSource>();

        if (Time.timeScale == 0) {
            a.Pause();
        }
        else if (Time.timeScale > 0)
        {
            a.UnPause();
        }
	}
}
