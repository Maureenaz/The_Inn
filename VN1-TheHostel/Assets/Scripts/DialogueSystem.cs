using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueSystem : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;

    public string[] sentences;
    private int index;

    public GameObject continueButton;

    public int myIndex;

    private int goodNumber = 0;
    public int myNumber = 0;

    public GameObject myChoice_1;
    public GameObject myChoice_2;
    public GameObject myChoice_3;
    public GameObject myChoice_4;

    public GameObject background_1;
    public GameObject background_2;

    public string[] scenes;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Type());
        background_2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // si le texte qui apparait est le même que celui de l'index du tableau alors le bouton
        // continue se manifeste
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }

        if (index == myIndex)
        {
            continueButton.SetActive(false);
            myChoice_1.SetActive(true);
            myChoice_2.SetActive(true);
            myChoice_3.SetActive(true);
            myChoice_4.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        // pour chaque lettre dans le tableau phrase faire apparître une lettre toute les 0.02 secondes
            foreach (char letters in sentences[index])
            {
                textDisplay.text += letters;
                yield return new WaitForSeconds(0.02f);
            }
    }

    public void NextSentences()
    {
        // si la longuer de la phrase est plus longue que l'index du tableau phrase, alors on fait index
        // +1 pour afficher la phrase suivante
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
            goodNumber += 1;
            Debug.Log(goodNumber);
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
        if (myNumber == goodNumber)
        {
            Debug.Log(" :3 ");
            background_1.SetActive(false);
            background_2.SetActive(true);
        }

    }

    public void MyChoice1()
    {
        Debug.Log(" <3 ");
        SceneManager.LoadScene(scenes[0]);
    }

    public void MyChoice2()
    {
        Debug.Log(" :3 ");
        SceneManager.LoadScene(scenes[1]);
    }

    public void MyChoice3()
    {
        Debug.Log(" :3 ");
        SceneManager.LoadScene(scenes[2]);
    }

    public void MyChoice4()
    {
        Debug.Log(" :3 ");
        SceneManager.LoadScene(scenes[3]);
    }
}
