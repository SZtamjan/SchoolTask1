using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GaneNabager : MonoBehaviour
{
    public TextMeshProUGUI response;
    public TextMeshProUGUI AIGuess;
    public TMP_InputField inputField;
    //Buttons
    public GameObject play;
    public GameObject smaller;
    public GameObject bigger;
    public GameObject playAgain;
    //text
    public GameObject endText;

    // Jak gracz kliknie Mniejsza liczba, to zgadni�ta liczba to currectMax
    // Jak gracz kliknie Wi�ksza liczba, to zgadni�ta liczba to currentMin

    //Og�lnie Maks
    public int maks;
    public int min;

    //Teraz Maks
    public int currentMin;
    public int currentMax;

    //Zmienne
    public int aiguess;
    public int zgadula;

    void Start()
    {
        response.text = "Start the game";

        currentMax = maks;
        currentMin = min;
        Debug.Log("Temp maks to "+currentMax);
        Debug.Log("Temp min to " +currentMin);
    }

    public void StartGame()
    {
        response.text = "Type the number to guess";
        play.gameObject.SetActive(!true);
    }


    public void GetInput(string input)
    {
        inputField.gameObject.SetActive(!true);
        Debug.Log("Liczba do zgadni�cia "+input);
        response.text = "The number is "+input;
        zgadula = Convert.ToInt32(input);
        RuchBota();
    }

    public void RuchBota()
    {
        //Ruch bota
        int newai = 0;
        newai = (currentMax + currentMin)/ 2;
        AIGuess.text = "AI guess is " + newai;
        aiguess = newai;
    }

    //Nowe currenty
    public void NewCurrentMin()
    {
        currentMin = aiguess;
        RuchBota();
        Debug.Log("Temp min to " + currentMin);
        CheckWin();
    }
    public void NewCurrentMax()
    {
        currentMax = aiguess;
        RuchBota();
        Debug.Log("Temp maks to " + currentMax);
        CheckWin();
    }

    public void CheckWin()
    {
        if (aiguess == zgadula)
        {
            //Wy��czenie przycisk�w
            bigger.SetActive(false);
            smaller.SetActive(false);
            inputField.gameObject.SetActive(false);
            endText.SetActive(true);
            playAgain.SetActive(true);

        }
    }

    public void egejn()
    {
        bigger.SetActive(!false);
        smaller.SetActive(!false);
        inputField.gameObject.SetActive(!false);
        endText.SetActive(!true);
        playAgain.SetActive(!true);

        currentMax = maks;
        currentMin = min;

        AIGuess.text = "I'll beat you again! >:3";
        response.text = "So again!";
    }

}
