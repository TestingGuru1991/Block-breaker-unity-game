using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBackground : MonoBehaviour
{
    void Awake()
    {
        int backgroundMusicCount = FindObjectsOfType<AudioBackground>().Length;
        if(backgroundMusicCount > 1) {
            Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
        }
    }
}
