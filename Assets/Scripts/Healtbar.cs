using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Healtbar : MonoBehaviour
{
    //until the levels are not made, for testing purposes i make the health drop by 10 each second
    public RawImage greenBar;
    public float decreaseSpeed = 1f;
    RectTransform rt;
    Vector3 currentPosition;
    Vector2 currentWidth;

    // Start is called before the first frame update
    void Start()
    {
        rt = greenBar.GetComponent<RectTransform>();
        currentPosition = greenBar.transform.localPosition;
        currentWidth = rt.sizeDelta;
    }

    private float timer = 0f;
    private float interval = 1f;

    void Update()
    {

    }

    public void DecreaseHealth()
    {
        
        if(rt.sizeDelta.x > 0)
        {
            currentPosition -= new Vector3(80, 0, 0);
            currentWidth -= new Vector2(160, 0);

            greenBar.transform.localPosition = currentPosition;
            rt.sizeDelta = currentWidth;
        }

    }
}
