using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Button : MonoBehaviour
{
    public GameObject creditScreen;
    // Start is called before the first frame update
    void Start()
    {
        creditScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log(" Quit •ﻌ•");
    }
    public void Credit()
    {
        creditScreen.SetActive(true);
    }

    public void Credit_Quit()
    {
        creditScreen.SetActive(false);
    }
}
