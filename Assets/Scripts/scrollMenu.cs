using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollMenu : MonoBehaviour {
    public float parallax = 2f;
    public float mainOffset = 0.2f;
	void Update () {

        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;
        offset.x += Time.deltaTime / parallax;
        offset.y += Time.deltaTime / (parallax * 50);
        mat.mainTextureOffset = offset;
	}
}
