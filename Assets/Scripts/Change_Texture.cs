using System.Collections;
using System.Collections.Generic;

using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Change_Texture : MonoBehaviour {

    //private Texture2D texture1;
    //private Texture2D texture2;
    //private GameObject picture;
    //private Material material;
    //public AudioClip impact;
    //private new AudioSource audio;

    //// Use this for initialization
    //void Start()
    //{
    //    Cursor.lockState = CursorLockMode.None;
    //    Cursor.visible = true;
    //    //texture1 = (Texture2D) AssetDatabase.LoadAssetAtPath("Assets/#Imports/pic001.jpg", typeof(Texture2D));
    //    //texture2 = (Texture2D) AssetDatabase.LoadAssetAtPath("Assets/#Imports/pic002.jpg", typeof(Texture2D));
    //    material = (Material)Resources.Load("#Imports/Materials/pic001.mat"); //AssetDatabase.LoadAssetAtPath("Assets/#Imports/Materials/pic001.mat", typeof(Material));
    //    if (material) Debug.Log("YES"); else Debug.Log("NO");
    //    audio = GetComponent<AudioSource>();
    //    if (audio == null)
    //        audio = gameObject.AddComponent<AudioSource>();
    //}

    ////// Update is called once per frame
    //void Update()
    //{

    //    if (Input.GetButtonDown("Change_Texture"))
    //    {
    //        if (texture1 && material && texture2)
    //        {
    //            if (material.GetTexture("_MainTex").name.Equals("pic001"))
    //                material.SetTexture("_MainTex", texture2);
    //            else
    //                material.SetTexture("_MainTex", texture1);
    //        }
    //        else
    //        {
    //            Debug.Log("Unable to Load texture || materials...");
    //        }
    //    }
    //}

    //void OnMouseDown()
    //{
    //    if (texture1 && material && texture2)
    //    {
    //        if (material.GetTexture("_MainTex").name.Equals("pic001"))
    //            material.SetTexture("_MainTex", texture2);
    //        else
    //            material.SetTexture("_MainTex", texture1);
    //    }
    //    else
    //    {
    //        Debug.Log("Unable to Load texture || materials...");
    //    }
    //    if (!audio.isPlaying)
    //        audio.PlayOneShot(impact, 1F);
    //}
}
