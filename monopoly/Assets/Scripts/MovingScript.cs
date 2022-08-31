using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovingScript : MonoBehaviour
{

    [SerializeField] private Transform[] locas;
    [SerializeField] private Transform player;
    [SerializeField] private int playerPos; 
    // Start is called before the first frame update
    void Start()
    {
        player.position = locas[0].position;
        playerPos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            int gayAmount = Random.Range(1, 6);
            playerPos = playerPos + gayAmount;
            if (locas.Length -1 < playerPos)
            {
                playerPos = playerPos - locas.Length;
            }
            player.position = locas[playerPos].position;
            
        }
    }
}
