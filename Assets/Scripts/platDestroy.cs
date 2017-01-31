using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platDestroy : MonoBehaviour {

    public GameObject platformDestroyPoint;

	void Start () {
        platformDestroyPoint = GameObject.Find("PlatformDestroyPoint");
	}
	
	void Update () {
		if(transform.position.x < platformDestroyPoint.transform.position.x)
        {
            gameObject.SetActive(false);
        }
	}
}
