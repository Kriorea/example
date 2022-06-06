using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachEndLevel : MonoBehaviour
{
    public LevelFinished levelFinished;
    public void OnTriggerEnter(Collider other)
    {
        levelFinished.NextLevelMenu();
    }
}
