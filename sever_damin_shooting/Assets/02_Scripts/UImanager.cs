
using UnityEngine;
using UnityEngine.UI;


public class UImanager : MonoBehaviour
{
    public Text BestScoreTxt;
    private int bestScore;
    public Text currentScoreTxt;
    private int currentScore;   
  
   public void SetScore(int value)
    {
        currentScore=value;
        currentScoreTxt.text = "점수: " + currentScore;
        PlayerPrefs.SetInt("Score", currentScore);
        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            BestScoreTxt.text = "최고점수: " + bestScore;
            PlayerPrefs.SetInt("Best Score", bestScore);
        }
    }
    public int GetScore()
    {
        return currentScore;
    }
       void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        BestScoreTxt.text = "최고점수: " + bestScore;
    }
  //  void Start()
   // {
   //     bestScore = PlayerPrefs.GetInt("Best Score", 0);
    //    BestScoreTxt.text = "Best Score : " + bestScore;
  // }
}
