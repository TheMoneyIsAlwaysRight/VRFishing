using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager instance;

    public GameManager Game { get { return instance; } }




    [ContextMenu("StartGame")]
    public void StartGame()
    {

    }




}
