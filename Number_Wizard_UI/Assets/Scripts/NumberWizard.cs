using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    // Use this for initialization
    int max;
    int min;
    int guess;
    public int maxGuessesAllowed;

    public Text number;


    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        NextGuess();
        
        
    }
  
    public void guessHigher()
    {
        min = guess;
        NextGuess();
    }

   public void guessLower()
    {
        max = guess;
        NextGuess();
    }
    void NextGuess()
    {
        guess = Random.Range(max+1 , min) ;
        number.text = guess.ToString();
        maxGuessesAllowed--;
        if (maxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }
      
    }
}