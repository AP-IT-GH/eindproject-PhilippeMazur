using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objective : MonoBehaviour
{
    // Start is called before the first frame update

    private int artifactsCollected;
    private bool playerIsTouched;
    void Start()
    {
        artifactsCollected = 0;
        playerIsTouched = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (artifactsCollected >= 5)
        {
            SceneManager.LoadScene("WinnerScene");
        }
        if (playerIsTouched)
        {
            SceneManager.LoadScene("GameOverScreen");
        }
    }

    public void IncrementArtifactsCollected()
    {
        artifactsCollected++;
    }

    public void PlayerGotTouched()
    {
        playerIsTouched = true;
    }

    public string displayPoints()
    {
        return artifactsCollected.ToString();
    }
    public void DecreaseArtifactsCollected()
    {
        artifactsCollected--;
        if (artifactsCollected < 0)
        {
            artifactsCollected = 0;
        }
    }
}