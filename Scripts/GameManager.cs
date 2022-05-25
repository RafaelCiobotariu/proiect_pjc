using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Minge ball;

    public Paleta playerPaddle;
    public Paleta computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;

    private int _playerScore = 0;

    private int _computerScore = 0;

    public void PlayerScores()
    {
        _playerScore++;
        // this.playerScoreText.text = _playerScore.ToString();
        this.computerPaddle.ResetPositionPaleta();
        this.playerPaddle.ResetPositionPaleta();
        this.ball.ResetBall();
    }


    public void ComputerScores()
    {
        _computerScore++;
        // this.computerScoreText.text = _computerScore.ToString();
        this.computerPaddle.ResetPositionPaleta();
        this.playerPaddle.ResetPositionPaleta();
        this.ball.ResetBall();
    }

}
