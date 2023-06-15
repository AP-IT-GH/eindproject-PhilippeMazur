using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Test");
        SceneManager.LoadScene("GameOverScreen");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Test");
        SceneManager.LoadScene("GameOverScreen");
    }
}
