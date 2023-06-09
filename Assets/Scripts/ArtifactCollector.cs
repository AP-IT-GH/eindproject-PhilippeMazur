using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ArtifactCollector : MonoBehaviour
{
    // Start is called before the first frame update
    public Text uiText;
    int artifactsBroughtToAltar;

    public void Start()
    {
        artifactsBroughtToAltar = 0;
    }

    private float timer = 0f;
    private float interval = 1f;
    void Update()
    {

    }

    public void CollectArtifact()
    {
        if(artifactsBroughtToAltar < 5)
        {
            artifactsBroughtToAltar += 1;
            if (uiText != null)
            {
                uiText.text = $"{artifactsBroughtToAltar} / 5";
            }
        }

    }
}
