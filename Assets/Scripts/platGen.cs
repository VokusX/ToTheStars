using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platGen : MonoBehaviour {

    public GameObject platform;
    public Transform genPoint;
    private float dist;
    public float distMin, distMax;
    private int platSelect;
    public objectPool[] objPool;

    private float minHeight, maxHeight, heightChange;
    public Transform maxHeightPoint;
    public float maxHeightChange;

    public float rndSpikeThreshold;
    public objectPool spikepool;

	void Start () {
        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;
	}
	
	void Update () {
		if(transform.position.x < genPoint.position.x)
        {

            dist = Random.Range(distMin, distMax);
            platSelect = Random.Range(0, objPool.Length);
            heightChange = transform.position.y + Random.Range(maxHeightChange, -maxHeightChange);
            if (heightChange > maxHeight)
                heightChange = maxHeight;
            else if (heightChange < minHeight)
                heightChange = minHeight;
            transform.position = new Vector3(transform.position.x + dist, heightChange, transform.position.z);
            
            //Instantiate(/*platform*/ plats[platSelect], transform.position, transform.rotation);

            GameObject newPlat = objPool[platSelect].GetPooledObject();
            newPlat.transform.position = transform.position;
            newPlat.transform.rotation = transform.rotation;
            newPlat.SetActive(true);

            if (Random.Range(0f, 100f) < rndSpikeThreshold)
            {
                GameObject newSpike = spikepool.GetPooledObject();


                Vector3 spikePos = new Vector3(0f, 1.55f, 0f);
                newSpike.transform.position = transform.position + spikePos;
                newSpike.transform.rotation = transform.rotation;
                newSpike.SetActive(true);
            }

            //transform.position = new Vector3(transform.position.x + dist, transform.position.y, transform.position.z);
        }
    }
}
