using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GaneNabager : MonoBehaviour
{
    public TextMeshProUGUI response;
    public TextMeshProUGUI AIGuess;
    public TMP_InputField inputField;
    public GameObject play;

    // Jak gracz kliknie Mniejsza liczba, to zgadniêta liczba to currectMax
    // Jak gracz kliknie Wiêksza liczba, to zgadniêta liczba to currentMin

    //Ogólnie Maks
    public int maks;
    public int min;

    //Teraz Maks
    public int currentMin;
    public int currentMax;

    public int aiguess;

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


    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetInput(string input,int newai)
    {
        Debug.Log("Liczba do zgadniêcia "+input);

        response.text = "The number is "+input;
        inputField.text = "";

        //Ruch bota
        newai = currentMax + currentMin / 2;
        AIGuess.text = "My guess is " + newai;


        /*if (int.TryParse(input, out int result))
        {
            if(result > randomNumber)
            {
                response.text = "Liczba jest wiêksza";
                Debug.Log("result jest wiekszy");
            }
            else if (result<randomNumber)
            {
                response.text = "Liczba jest mniejsza";
                Debug.Log("result jest mniejszy ");
            }
            else if (result == randomNumber)
            {
                response.text = "Zgad³eœ!";
                Debug.Log("result jest rowny");
                play.gameObject.SetActive(true);
            }
        }*/


    }


    //Nowe currenty
    public void NewCurrentMin(int newai)
    {
        
        currentMax = newai;
        Debug.Log("Temp min to " + currentMin);
        GetInput(newai);

    }
    public void NewCurrentMax(int newai)
    {
        GetInput();
        currentMin = newai;
        Debug.Log("Temp maks to " + currentMax);
        GetInput();
    }

}
