﻿using UnityEngine;
using System.Collections;

public class Choosegame : MonoBehaviour {

    public void Back_To_Menu()
    {
        Application.LoadLevel(1);
    }
    public void StartGame()
    {
        Application.LoadLevel("Map1");
    }
}
