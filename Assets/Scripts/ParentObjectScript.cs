using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentObjectScript : MonoBehaviour
{
    public GameObject mainGameObject;
    public GameObject welcomeObject;
    public Animator welcomObjectAnimation;
    public Animator mainGameObjectAnimation;

    public ExploreSectionController exploreSectionController;
    public GameObject mainMenu;
    
    public void playWelcomeAnimation()
    {
        welcomObjectAnimation.enabled = true;
    }

    public void StartGame()
    {
        welcomeObject.SetActive(false);
        enableMainMenu();
    }

    public void enableExploreSection()
    {
        disableMainMenu();
        exploreSectionController.enable();
    }

    public void disableExploreSection()
    {
        exploreSectionController.disable();
    }

    public void disableMainMenu()
    {
        mainGameObject.SetActive(false);
        mainGameObjectAnimation.enabled = false;
    }
    public void enableMainMenu()
    {
        mainGameObject.SetActive(true);
        mainGameObjectAnimation.enabled = true;
    }
}
