using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager ins;
    public delegate void GazedObject(string name);
    public static GazedObject gazedObject;

    // gaze mechanics
    public GameObject gaze;
    public float findingSquareDist = 0.5f;
    public float maxRayDistance = 60.0f;
    public LayerMask collisionLayerMask;
    private Vector3 _initialGazeScale;

    // state control variables
    public bool parentObjectPlaced = false;

    public GameObject welcomeUI;
    public GameObject planeGenerator;
    public GameObject introMsg;

    public ParentObjectScript parentObjectController;

    public GameObject ExploreBackButtonUI;

    void Start()
    {
        _initialGazeScale = gaze.transform.localScale;
        gazedObject += DebugName;
    }

    private void Awake()
    {
        if (ins == null)
        {
            ins = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    Transform _lastGazedUpon = null;
    void Update()
    {
        //use center of screen for focusing
        Vector3 center = new Vector3(Screen.width / 2, Screen.height / 2, findingSquareDist);
        Ray ray = Camera.main.ScreenPointToRay(center);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, maxRayDistance, collisionLayerMask))
        {
            Debug.Log(hit.transform.name);

            //lerp the size of gaze
            gaze.transform.localScale = Vector3.Lerp(gaze.transform.localScale, new Vector3(1f, 1f, 1f), 0.2f);

            if (_lastGazedUpon != null)
            {
                /*if (hit.transform.tag == "ExploreCube" || hit.transform.tag == "LocationMarker")
                {
                    Manager.gazedObject(hit.transform.parent.name);
                }
                else
                {
                    Manager.gazedObject(hit.transform.name);
                }*/
                gazedObject(hit.transform.name);
            }

            _lastGazedUpon = hit.transform;
            return;
        }
        gazedObject("");
        gaze.transform.localScale = Vector3.Lerp(gaze.transform.localScale, _initialGazeScale, 0.2f);
    }

    public void setParentObjectPlaced(bool value)
    {
        parentObjectPlaced = value;
    }

    public void StartGame()
    {
        parentObjectController.StartGame();
        welcomeUI.SetActive(false);
        planeGenerator.SetActive(false);
    }


    public void DebugName(string name)
    {
        if (name != "")
            Debug.Log("gazing " + name);
    }

    public void disableIntro()
    {
        introMsg.SetActive(false);
    }

    public void activateMainMenu()
    {

    }

    public void disableMainMenu()
    {

    }

    public void activateQuiz()
    {

    }

    public void disableQuiz()
    {

    }

    public void activateInvestSim()
    {
        parentObjectController.enableInvestSimObject();
    }

    public void disableInvestSim()
    {

    }

    public void activateExploreButtonUI()
    {
        Debug.Log("valle");
        ExploreBackButtonUI.SetActive(true);
    }


    public void disableExplore()
    {
        ExploreBackButtonUI.SetActive(false);
        parentObjectController.disableExploreSection();
    }

    public void activateExploreSectionUI()
    {

    }

    public void activateEstore()
    {

    }

    public void disableEstore()
    {

    }
}
