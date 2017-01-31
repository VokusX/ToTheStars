using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    Text txt;
    float currentscore = 0f;
    public float scoreInc = 0.01f;

    void Start () {
        txt = gameObject.GetComponent<Text>();
        txt.text = "Score : " + currentscore;
    }

	void Update () {
        if (Time.timeScale == 0)
        {
            updateText((int)currentscore);

        }
        else
        {
            currentscore += scoreInc;
            txt.text = "Score : " + (int)currentscore;
        }
    }

    void updateText(int cs)
    {
        txt.text = "Score : " + cs;
    }
}
