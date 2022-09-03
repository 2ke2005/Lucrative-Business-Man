using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovingScript : MonoBehaviour
{
    public void rollDice()
    {
        //set activeplayerlocation to be the active player's
        activePlayerLoc = playersLoc[activePlayer];
        

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
        playersLoc[activePlayer] = activePlayerLoc;
        

        // Move the player object
        playerPiece[activePlayer].position = locas[playersLoc[activePlayer]].position;


        // change turn 
        activePlayer++;
        if (activePlayer >= playersLoc.Length ) { activePlayer = 0; }

    }
    public int activePlayerLoc = 0;
    [SerializeField] private Transform[] locas;
    [SerializeField] private Transform[] playerPiece;
    [SerializeField] private int activePlayer = 0;
    [SerializeField] private int[] playersLoc;
    // Start is called before the first frame update
    void Start()
    {
        // set locations to start value
        for (int i = 0; i < playersLoc.Length; i++)
        {
            playersLoc[i] = 0;
        }
        // set pos to start value
        for (int i = 0; i < playerPiece.Length; i++)
        {
            playerPiece[i].position = locas[playersLoc[i]].position;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
