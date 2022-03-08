using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourManager : MonoBehaviour
{
    public GameObject[] objSites;
    public GameObject  canvasMainMenu;
    public bool isCameraMove = false;
    
    // Start is called before the first frame update
    void Start()
    {
        ReturnToMenu();
    }
    // Update is called once per frame
    void Update()
    {
        if(isCameraMove)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                ReturnToMenu();
            }
            if(Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if(Physics.Raycast(ray, out hit, 100.0f))
                {
                    if(hit.transform.gameObject.tag == "Sound")
                    {
                        hit.transform.gameObject.GetComponent<MediaAudio>().PlayAudio();
                    }
                    else if(hit.transform.gameObject.tag == "Image")
                    {
                        hit.transform.gameObject.GetComponent<MediaImage>().ShowImage();
                    }
                    else if(hit.transform.gameObject.tag == "Video")
                    {
                        hit.transform.gameObject.GetComponent<MediaVideo>().ShowVideo();
                    }
                }
            }
        }
    }
    public void LoadSite(int siteNumber)
    {
        objSites[siteNumber].SetActive(true);
        canvasMainMenu.SetActive(true);
        isCameraMove = true;
        GetComponent<CameraController>().ResetCamera();
    }
    public void ReturnToMenu()
    {
        canvasMainMenu.SetActive(true);
        for(int i = 0; i<objSites.Length; i++)
        {
            objSites[i].SetActive(false);
        }
        isCameraMove = false;
    }

    public void ReturnToSite()
    {
        isCameraMove = true;
    }
    public void OpenMedia()
    {
        isCameraMove = false;
    }
}
