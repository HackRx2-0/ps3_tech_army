using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentObjectScript : MonoBehaviour
{
    public GameObject mainGameObject;
    public GameObject welcomeObject;
    public Animator welcomObjectAnimation;
    public Animator mainGameObjectAnimation;

    public void playWelcomeAnimation()
    {
        welcomObjectAnimation.enabled = true;
    }

    public void StartGame()
    {
        welcomeObject.SetActive(false);
        mainGameObject.SetActive(true);
        mainGameObjectAnimation.enabled = true;
    }

}
