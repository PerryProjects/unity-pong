using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScore;
    public Text computerScore;


    private int _playerScore = 0;
    private int _computerScore = 0;

    public void PlayerScore() {
        _playerScore++;
        playerScore.text = _playerScore.ToString();
        ResetRound();
    }

    private void ResetRound() {
        ball.ResetPosition();
        playerPaddle.ResetPosition();
        ball.AddStartingForce();
    }

    public void ComputerScore() {
        _computerScore++;
        computerScore.text = _computerScore.ToString();
        ResetRound();
    }
}
