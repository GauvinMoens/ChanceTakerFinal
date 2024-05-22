using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    [SerializeField] CanvasGroup canvas;
    bool fadeOut = false;
    private void Start()
    {
        canvas.alpha = 0;
    }

    private void Update()
    {
        if(fadeOut == true)
        {
            if (canvas.alpha < 1)
            {
                canvas.alpha += Time.deltaTime;
                Debug.Log(canvas.alpha);
            }
        }
    }

    public void StartButton()
    {
        Invoke("FadeOutImg", 2);
    }

    public void FadeOutImg()
    {
        fadeOut = true;
    }
}
