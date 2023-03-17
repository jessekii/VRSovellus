using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonpress : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject structure;
    private GameObject instantiatedSt;
    public GameObject throwable;
    private GameObject instantiatedTh;

    void Start()
    {
        instantiatedSt = (GameObject) Instantiate(structure, new Vector3(0.2f, 0.85f, 10f), Quaternion.identity);
        instantiatedTh = (GameObject) Instantiate(throwable, new Vector3(0f, 0.5f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressButton(){
        Destroy(instantiatedSt, 0);
        Destroy(instantiatedTh, 0);
        instantiatedSt = (GameObject) Instantiate(structure, new Vector3(0.2f, 0.85f, 10f), Quaternion.identity);
        instantiatedTh = (GameObject) Instantiate(throwable, new Vector3(0f, 0.5f, 0f), Quaternion.identity);
        Debug.Log("Respawned!");
    }
}
