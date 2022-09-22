using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveFromSceneToSceen : MonoBehaviour
{
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Scene scene = SceneManager.GetActiveScene();
        //If you are in the pocket dimension you can tp only to the begging
        if (scene.name == "PocketDimension")
            SceneManager.LoadScene("FirstFloorPrison");
        else if (tag == "PocketDimension")
            SceneManager.LoadScene("PocketDimension");
        else if (scene.name == "FirstFloorPrison")
            SceneManager.LoadScene("SecondFloorCourtyard");
        else if (scene.name == "SecondFloorCourtyard")
            SceneManager.LoadScene("ThirdFloorKitchen");
        else if (scene.name == "ThirdFloorKitchen")
            SceneManager.LoadScene("FourthFloorThroneRoom");
    }

}
