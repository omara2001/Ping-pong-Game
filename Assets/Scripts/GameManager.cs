using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public PAUSE PAUSE;
    public Paddle playerPaddle;
    public int playerScore { get; private set; }
    public Text playerScoreText;
    public GameObject WinPanel, LosePanel;
    public Paddle computerPaddle;
    public int computerScore { get; private set; }
    public Text computerScoreText;

    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            NewGame();
        }
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
    }

    public void StartRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

    public void PlayerScores()
    {
        SetPlayerScore(playerScore + 1);
        StartRound();
    }

    public void ComputerScores()
    {
        SetComputerScore(computerScore + 1);
        StartRound();
    }
    public void SetPlayerScore(int score)
    {
        playerScore = score;
        playerScoreText.text = score.ToString();
        if (playerScore == 21)
        {
            WinPanel.transform.GetChild(0).GetComponent<Text>().text = "YOUWIN!";
            WinPanel.SetActive(true);
            gameObject.SetActive(false);
            Application.Quit();
            SetComputerScore(0);
            SetPlayerScore(0);
            void Restart()
            {
                NewGame();
                SetPlayerScore(0);
                SetComputerScore(0);
                StartRound();
            }
            void Exit()
            {
                SceneManager.LoadScene("MainMenu");
            }

        }
    }

    public void SetComputerScore(int score)
    {
        computerScore = score;
        computerScoreText.text = score.ToString();
        if (computerScore == 21)
        {
            Application.Quit();
            SetComputerScore(0);
            SetPlayerScore(0);
            LosePanel.transform.GetChild(0).GetComponent<Text>().text = "YOULOSE...";
            LosePanel.SetActive(true);
            gameObject.SetActive(false);
            
            void Restart()
            {
                NewGame();
                SetPlayerScore(0);
                SetComputerScore(0);
                StartRound();
            }
            void Exit()
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }

}












