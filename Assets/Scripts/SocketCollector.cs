using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketCollector : MonoBehaviour
{
    public Objective objective;


    private void Start()
    {
        objective = objective.GetComponent<Objective>();
    }
    void OnCollisionEnter(Collision collision)
    {
        objective.IncrementArtifactsCollected();
        Debug.Log("artifacts collected: " + objective.displayPoints());
    }
    void OnSelectEnter()
    {

    }
}
