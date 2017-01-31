using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killbox : MonoBehaviour {
    private Transform kb;
    Vector3 pos;

    public 

    void Start () {
        pos = Camera.main.gameObject.transform.position;
        kb = gameObject.GetComponent<Transform>();
    }
	
	void Update () {
        pos.y = -15;
        pos.x = Camera.main.gameObject.transform.position.x;
        kb.transform.position = pos;
    }
}
