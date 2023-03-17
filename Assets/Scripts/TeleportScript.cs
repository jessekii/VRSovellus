using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    // Start is called before the first frame update
    private RaycastHit raycastHit;
    public GameObject playerFace;

    private GameObject Look(){
        Vector3 origin = playerFace.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        float range = 1000;
        if(Physics.Raycast(origin, direction, out raycastHit, range)){
            if(raycastHit.collider.tag == "floor"){
                return raycastHit.collider.gameObject;
            } else {
                return null;
            }
            
        } else {
            return null;
        }
    }

    private void Teleport(){
        playerFace.transform.position = new Vector3(raycastHit.point.x,0, raycastHit.point.z) + new Vector3(raycastHit.normal.x, 0.75f, raycastHit.normal.z) * 2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = playerFace.transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(playerFace.transform.position, forward, Color.green);
        if (Input.GetKeyDown(KeyCode.Mouse2)){
            if(Look() != null){
                Teleport();
                Debug.Log("Test!");
            }
            
        }
    }
}
