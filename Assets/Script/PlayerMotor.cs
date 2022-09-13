using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    public void LookInBuggage()
    {
        print("Me rotating");
        GameObject.Find("CameraInBaggage").GetComponent<Camera>().enabled =true ;

    }
}
