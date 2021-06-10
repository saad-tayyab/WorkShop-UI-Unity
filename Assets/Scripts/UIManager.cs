using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(RectTransform))]
public class UIManager : MonoBehaviour
{

    public RectTransform showBackground, showBottomOfShop, showTopOfShop, showLeftSide, showRightSide, showSlidingWindow;
    float delay, animateTime;

    #region Getter
    static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<UIManager>();
            if (instance == null)
                Debug.LogError("UIManager not found");
            return instance;
        }
    }
    #endregion Getter

    void Start()
    {
        delay = 0.9f;
        animateTime = 0.5f;

        ShowBackground();
        ShowSlidingWindow(delay);

        FadeAnimation(0f, 0f);
        //FadeAnimation(animateTime, delay);
        Invoke("revertback", delay);
    }

    public enum Axes {
        X, Y
    }
    
    void revertback()
    {
        FadeAnimation(animateTime, 0f);
    }

    public void ToggleSlide(RectTransform fadeRect, Axes axes, float animateTime = 0.5f, float delay = 0f) {

        if(axes == Axes.X) {
            float x = fadeRect.anchoredPosition.x * -1;
            fadeRect.DOAnchorPosX(x, animateTime).SetDelay(delay);
        }
        else if (axes == Axes.Y) {
            float y = fadeRect.anchoredPosition.y * -1;
            fadeRect.DOAnchorPosY(y, animateTime).SetDelay(delay);
        }
    }

    public void FadeAnimation(float animateTime, float delay) {
          ToggleSlide(showBottomOfShop, Axes.Y, animateTime, delay);
          ToggleSlide(showTopOfShop, Axes.Y, animateTime, delay);
          ToggleSlide(showLeftSide, Axes.X, animateTime, delay);
          ToggleSlide(showRightSide, Axes.X, animateTime, delay);
    }

    

    public void ShowBackground(float delay = 0f)
    {
        showBackground.DOAnchorPosX(0, 0f);
        showBackground.DOScale(new Vector3((float) 1.0, (float)1.0, (float)1.0), 1.1f).SetDelay(delay);
    }    

    public void ShowSlidingWindow(float delay = 0f)
    {
        showSlidingWindow.DOAnchorPosX(-200, 0.5f).SetDelay(delay);
        showSlidingWindow.DOAnchorPosX(0, 0.5f).SetDelay(delay + 0.5f);
    }
}
