using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
    private void Start()
    {
        // let's start by setting our player dancing stats to random numbers
        // style should be random between 1-10
      
        int playerOneStyle = Random.Range(1, 11);
        // luck should be random between 0-4
       
        int playerOneLuck = Random.Range(0, 5);
        // ryhtm should be random between 1-6
        
        int playerOneRythm = Random.Range(1, 6);
        // style should be random between 1-10
       
        int playerTwoStyle = Random.Range(1, 11);
        // luck should be random between 0-4
        
        int playerTwoLuck = Random.Range(0, 5);
        // ryhtm should be random between 1-6
        
        int playerTwoRythm = Random.Range(1, 7);

        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        // this algorthim should be the same for each character to keep it fair.
        int playerOnePowerLevel = playerOneStyle+playerOneLuck+playerOneRythm;    
        int playerTwoPowerLevel = playerTwoStyle+playerTwoLuck+playerTwoRythm;

      

        // Debug out the two players, power levels.

        Debug.Log(playerOnePowerLevel);
        Debug.Log(playerTwoPowerLevel);

        // calculate the percentage chance of winning the fight for each character.
        // todo this you'll need to add the two powers together, then divide you characters power against this and multiply the result by 100.
        int totalPower = playerOnePowerLevel+playerTwoPowerLevel;
        int playerOneChanceToWin = PlayerOneChanceToWin/(totalpower*100);
        int playerTwoChanceToWin = playerTwoChanceToWin/(totalpower*100);


        // Debug out the chance of each character to win.

        
        Debug.Log(PlayerOneChanceToWin);
        Debug.Log(PlayerTwoChanceToWin);
      
        if (playerOneChanceToWin > playerTwoChanceToWin)
        {
            Debug.Log("player One Wins");
         
        }
        else if(playerOneChanceToWin < playerTwoChanceToWin)
        {
            Debug.Log("Player Two Wins");
            
        }
        else
        {
            Debug.Log("DRAW!!!");
           
        }

      





        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.  

            // Debug out which character has won, which has lost, or if it's a draw.  
            // Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.
    }
}
