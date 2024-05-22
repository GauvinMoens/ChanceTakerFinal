using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    [SerializeField] CanvasGroup canvas;
    private void Start()
    {
        canvas.alpha = 1;
    }

    private void Update()
    {
        if (canvas.alpha > 0)
        {
            canvas.alpha -= Time.deltaTime;
        }
    }

}
