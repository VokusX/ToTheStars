using UnityEngine;
using System.Collections;


public class CameraScreenGrab : MonoBehaviour {
		
	public float pixelSize = 4;
	public FilterMode filterMode = FilterMode.Point;
	public Camera[] otherCameras;
	private Material mat;
	Texture2D tex;
	
	void Start () {
        GetComponent<Camera>().pixelRect = new Rect(0,0,Screen.width/pixelSize,Screen.height/pixelSize);
		for (int i = 0; i < otherCameras.Length; i++)
			otherCameras[i].pixelRect = new Rect(0,0,Screen.width/pixelSize,Screen.height/pixelSize);
	}
	
	void OnGUI()
	{
		if (Event.current.type == EventType.Repaint)
			Graphics.DrawTexture(new Rect(0,0,Screen.width, Screen.height), tex);
	}
	

	void OnPostRender()
	{
			
		DestroyImmediate(tex);

		tex = new Texture2D(Mathf.FloorToInt(GetComponent<Camera>().pixelWidth), Mathf.FloorToInt(GetComponent<Camera>().pixelHeight));
		tex.filterMode = filterMode;
		tex.ReadPixels(new Rect(0, 0, GetComponent<Camera>().pixelWidth, GetComponent<Camera>().pixelHeight), 0, 0);
		tex.Apply();
	}

}
