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

    public GameObject profileSection;
    public Animator profileAnimator;

    public GameObject investSimObject;
    public Animator investSimAnimator;

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
        Manager.ins.activateExploreButtonUI();
    }

    public void disableExploreSection()
    {
        exploreSectionController.disable();
        enableMainMenu();
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

    public void enableProfileSection()
    {
        profileSection.SetActive(true);
        profileAnimator.enabled = true;
        disableMainMenu();
    }

    public void enableInvestSimObject()
    {
        investSimObject.SetActive(true);
        investSimAnimator.enabled = true;
        disableMainMenu();
    }

}
