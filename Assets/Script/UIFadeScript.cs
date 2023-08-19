using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;
public class UIFadeScript : MonoBehaviour
{
    public enum FadeType
    {
        FadeIN, FadeOut
    }
    // Use this for initialization
    [Range(1, 4)]
    public float TimeToFadeIN = 4;
    public FadeType type;
    void OnEnable()
    {
       // StartFade();
    }
    void StartFade()
    {
        switch (type)
        {
            case FadeType.FadeIN:
                fadeIn();
                break;
            case FadeType.FadeOut:
                fadeOut();
                break;
        }
    }
  public  void fadeIn()
    {
        //first set all to zero
        foreach (Image img in transform.GetComponentsInChildren<Image>())
        {
            img.CrossFadeAlpha(0, 0, true);
        }
        //first set all to zero
        foreach (Text txt in transform.GetComponentsInChildren<Text>())
        {
            txt.CrossFadeAlpha(0, 0, true);
        }
        //uncomment if using Textmeshpro
        //foreach (TextMeshProUGUI txt in transform.GetComponentsInChildren<TextMeshProUGUI>())
        //{
        //    txt.CrossFadeAlpha(0, 0, true);
        //}

        //next bring their alpha to 1 
        foreach (Image img in transform.GetComponentsInChildren<Image>())
        {
            img.CrossFadeAlpha(1, TimeToFadeIN, true);
        }
        foreach (Text txt in transform.GetComponentsInChildren<Text>())
        {
            txt.CrossFadeAlpha(1, TimeToFadeIN, true);
        }
        //uncomment if using Textmeshpro
        //foreach (TextMeshProUGUI txt in transform.GetComponentsInChildren<TextMeshProUGUI>())
        //{
        //    txt.CrossFadeAlpha(1, TimeToFadeIN, true);
        //}
    }
    public void fadeOut()
    {
        //first set all to zero
        foreach (Image img in transform.GetComponentsInChildren<Image>())
        {
            img.CrossFadeAlpha(1, 0, true);
        }
        //first set all to zero
        foreach (Text txt in transform.GetComponentsInChildren<Text>())
        {
            txt.CrossFadeAlpha(1, 0, true);
        }
        //uncomment if using Textmeshpro
        //foreach (TextMeshProUGUI txt in transform.GetComponentsInChildren<TextMeshProUGUI>())
        //{
        //    txt.CrossFadeAlpha(1, 0, true);
        //}

        //next bring their alpha to 1 
        foreach (Image img in transform.GetComponentsInChildren<Image>())
        {
            img.CrossFadeAlpha(0, TimeToFadeIN, true);
        }
        foreach (Text txt in transform.GetComponentsInChildren<Text>())
        {
            txt.CrossFadeAlpha(0, TimeToFadeIN, true);
        }
        //uncomment if using Textmeshpro
        //foreach (TextMeshProUGUI txt in transform.GetComponentsInChildren<TextMeshProUGUI>())
        //{
        //    txt.CrossFadeAlpha(0, TimeToFadeIN, true);
        //}
    }
}
