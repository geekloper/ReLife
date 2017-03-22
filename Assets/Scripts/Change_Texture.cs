﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Texture : MonoBehaviour {

    private Texture2D texture1;
    private Texture2D texture2;
    private GameObject picture;
    private Material material;

    // Use this for initialization
    void Start () {
        texture1 = (Texture2D)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/#Imports/pic001.jpg", typeof(Texture2D));
        texture2 = (Texture2D)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/#Imports/pic002.jpg", typeof(Texture2D));
        material = (Material)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/#Imports/Materials/pic001.mat", typeof(Material));
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Change_Texture"))
        {
            if (texture1 && material && texture2)
            {
                if (material.GetTexture("_MainTex").name.Equals("pic001"))
                    material.SetTexture("_MainTex", texture2);
                else
                    material.SetTexture("_MainTex", texture1);
            }
            else
            {
                Debug.Log("Unable to Load texture || materials...");
            }
        }
    }
}