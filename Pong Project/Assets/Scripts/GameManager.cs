using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
    }

    public void ComputerScores()
    {
        _computerScore++;
    }
}
