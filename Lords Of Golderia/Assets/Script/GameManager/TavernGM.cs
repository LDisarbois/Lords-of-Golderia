using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TavernGM : MonoBehaviour
{
    // Start is called before the first frame update

    private int nbreJoueurs;

    public PlayerInputManager  playerInputManger;
    public GameObject[] Players;

    void Start()
    {
        playerInputManger.DisableJoining();
        nbreJoueurs = playerInputManger.playerCount;
        Players = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if(nbreJoueurs == 1 )
        {
            int winnerIndex = Players[0].GetComponent<PlayerInput>().playerIndex;
            
        }
        
    }
}
