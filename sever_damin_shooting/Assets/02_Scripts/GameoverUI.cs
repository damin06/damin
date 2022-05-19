using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameoverUI : MonoBehaviour
{
    public Text currentScoreTxt;
    private int currentScore;
    public Text BestScoreTxt;
    private int bestScore;
    private void Start()
    {
        currentScore = PlayerPrefs.GetInt("Score", 0);
        currentScoreTxt.text = "점수: " + currentScore;
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        BestScoreTxt.text = "최고점수: " + bestScore;
    }
    public void BtnStart()
    {
        SceneManager.LoadScene("Play");
    }
}
