using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchController : MonoBehaviour {

    public enum SwitchType { Bridge, Elevator, FallingObject, Door};
    public SwitchType switchType;
    public Text interactionMessage;
    public GameObject actionObject;
    public void ActiveSwitch()
    {
        


    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            //interactionMessage.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                if (switchType == SwitchType.Door)
                {
                    actionObject.GetComponent<Doors>().isActive = true;
                }
            }
            
        }
        if (other.gameObject.tag == "Player")
        {
            //interactionMessage.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                if (switchType == SwitchType.Bridge)
                {
                    actionObject.GetComponent<Bridge>().isActive = true;                    
                }
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        //interactionMessage.gameObject.SetActive(false);
    }
}
