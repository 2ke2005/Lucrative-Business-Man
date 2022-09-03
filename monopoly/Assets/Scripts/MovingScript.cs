using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovingScript : MonoBehaviour
{
    public void rollDice()
    {
        if (activePlayerIs1 == true) {
            activePlayerLoc = player1Loc;
        }
        else
        {
            activePlayerLoc = player2Loc; 
        }

       
        // get random amount to move
        int gayAmount = Random.Range(1, 6);
        // add dice roll to location of player
        activePlayerLoc = activePlayerLoc + gayAmount;
        // make sure it loops
        if (locas.Length - 1 < activePlayerLoc)
        {
            activePlayerLoc = activePlayerLoc - locas.Length;
        }
        // update location 
        if (activePlayerIs1)
        {
            player1Loc = activePlayerLoc;
        }
        else
        {
            player2Loc = activePlayerLoc;
        }



        // Move the player object
        
        
        player1.position = locas[player1Loc].position;
        player2.position = locas[player2Loc].position;
        

        // change turn 
        activePlayerIs1 = !activePlayerIs1;

    }
    public int activePlayerLoc = 0;
    [SerializeField] private Transform[] locas;
    [SerializeField] private Transform player1;
    [SerializeField] private Transform player2;
    [SerializeField] private int player1Loc;
    [SerializeField] private int player2Loc;
    [SerializeField] private bool activePlayerIs1;
    // Start is called before the first frame update
    void Start()
    {
        // active player is  one
        activePlayerIs1 = true;

        player1.position = locas[0].position;
        player1Loc = 0;   
        player2Loc = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown("m"))
        {
            rollDice();
        }*/
    }
}
