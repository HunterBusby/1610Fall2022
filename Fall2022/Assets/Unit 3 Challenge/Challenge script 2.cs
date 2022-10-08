using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challengescript2 : MonoBehaviour
{
    int playerTurn = 5;
    
    
    void Start ()
    {
        playerTurn = Turndouble(playerTurn);
        Debug.Log (playerTurn);
    }
    
    
    int Turndouble (int hex)
    {
        int result;
        result = hex * 2;
        return result;
    }
}
