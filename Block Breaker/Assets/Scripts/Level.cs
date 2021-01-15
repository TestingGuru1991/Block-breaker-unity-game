using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks;
    
    // Cached reference
    SceneLoader sceneloader;

    private void Start() {
        sceneloader = FindObjectOfType<SceneLoader>();
    }

    public void CountBreakableBlocks() {
        breakableBlocks++;
    }

    public void BlockDestroyed() {
        breakableBlocks--;
        if(breakableBlocks <= 0) {
            // Load next level
            sceneloader.LoadNextScene();
        }
    }
}
