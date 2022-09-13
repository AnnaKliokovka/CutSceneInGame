using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Interactable focused;
    PlayerMotor motor;

    private void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("E");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                Interactable interactable =  hit.collider.GetComponent<Interactable>();
                if(interactable != null)
                {
                    SetFocus(interactable);
                }
            }
        }
    }

    void SetFocus(Interactable newFocus)
    {
        focused = newFocus;
        if (newFocus.gameObject.name == "Baggage")
        {
            motor.LookInBuggage();
        }
    }

    void RemoveFocus()
    {
        focused = null;
    }
}
