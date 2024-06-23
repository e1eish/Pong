using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _computerScore;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerScores()
    {
        _playerScore++;
        Debug.Log(_playerScore);
        ball.ResetPosition();
    }

    public void ComputerScores()
    {
        _computerScore++;
        Debug.Log(_computerScore);
        ball.ResetPosition();
    }
}
