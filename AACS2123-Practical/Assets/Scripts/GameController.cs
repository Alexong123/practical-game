using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI ScoreV;
    public int score = 0;

    

    public void changeScore(int gemValue)
    {
        score += gemValue;
   
        
        
        text.text = score.ToString();

        
        if(score>=130)
        {
            ScoreV.text = "Well Done!";
        }
            
        
    }


   
}
