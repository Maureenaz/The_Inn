using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChoiceMenu : MonoBehaviour
{
    public GameObject langue_1;
    public GameObject langue_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Choice_1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Choice_2()
    {
        SceneManager.LoadScene("SceneFR_1");
    }
}
