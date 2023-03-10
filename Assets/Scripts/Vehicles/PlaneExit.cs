using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneExit : MonoBehaviour
{
    public GameObject vehicleCam;
    public GameObject thePlayer;
    public GameObject liveVehicle;
    public GameObject entryTrig;
    public GameObject planeHUD;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
            {
                thePlayer.SetActive(true);
                vehicleCam.SetActive(false);
                
                liveVehicle.GetComponent<PlaneController>().enabled = false;
                liveVehicle.GetComponent<AudioSource>().enabled = false;
                thePlayer.transform.parent = null;
                StartCoroutine(EnterAgain());
            }
    }

    IEnumerator EnterAgain()
     {
        yield return new WaitForSeconds(0.5f);
        entryTrig.GetComponent<BoxCollider>().enabled = true;
        this.gameObject.SetActive(false);
        planeHUD.SetActive(false);

    }
}
