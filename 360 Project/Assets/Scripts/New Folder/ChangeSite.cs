using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSite : MonoBehaviour
{
    public GameObject[] site;
    public bool isCameraMove = false;
    private int siteNumber;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if(Physics.Raycast(ray, out hit, 100.0f))
                {
                    site[siteNumber].SetActive(true);
                    isCameraMove = true;
                    GetComponent<CameraController>().ResetCamera();
                }
            }
    }
}
