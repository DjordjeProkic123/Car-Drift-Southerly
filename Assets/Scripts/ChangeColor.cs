using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{   
    public GameObject plane;
    private GameObject[] listaObj;
    
    public void changePrimaryColorBlue()
    {   
        listaObj = GameObject.FindGameObjectsWithTag("Mesh");
        foreach(var a  in listaObj){
            Material material = a.GetComponent<MeshRenderer>().materials[0];
            material.color = new Color(0, 0, 255, 255);
        }
    }
    public void changePrimaryColorPurple()
    {
        listaObj = GameObject.FindGameObjectsWithTag("Mesh");
        foreach(var a  in listaObj){
            Material material = a.GetComponent<MeshRenderer>().materials[0];
            material.color = new Color(200, 0, 255, 255);
        }

    }
    public void changePrimaryColorRed()
    {
         listaObj = GameObject.FindGameObjectsWithTag("Mesh");
        foreach(var a  in listaObj){
            Material material = a.GetComponent<MeshRenderer>().materials[0];
            material.color = new Color(255, 0, 0, 255);
        }
    }

    /////////////////////////////////////////////////////////////////////////////
    public void changeSecondaryColorWHITE()
    {
          listaObj = GameObject.FindGameObjectsWithTag("Mesh");
        foreach(var a  in listaObj){
            Material material = a.GetComponent<MeshRenderer>().materials[6];
            material.color = new Color(255, 255, 255, 255);
        }
    }
    public void changeSecondaryColorBLACK()
    {
        listaObj = GameObject.FindGameObjectsWithTag("Mesh");
        foreach(var a  in listaObj){
            Material material = a.GetComponent<MeshRenderer>().materials[6];
            material.color = new Color(0, 0, 0, 255);//(0, 0, 0, 255); //BLACK
        }
    }
    public void changeSecondaryColorYELLOW()
    {
        listaObj = GameObject.FindGameObjectsWithTag("Mesh");
        foreach(var a  in listaObj){
            Material material = a.GetComponent<MeshRenderer>().materials[6];
            material.color = new Color(255, 255, 0, 255);
        }
    }



/////////////////////////////////////////////////////////////////////////////////////////////
    public void changeBGColorGreen()
    {
        plane.GetComponent<Renderer>().material.color = new Color32(124,255,208,255);
    }
    public void changeBGColorRed()
    {
        plane.GetComponent<Renderer>().material.color = new Color32(255,126,70,255);
    }
    public void changeBGColorBlue()
    {
        plane.GetComponent<Renderer>().material.color = new Color32(124,211,255,255);
    }
}
    
