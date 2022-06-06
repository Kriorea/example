using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelFinished : MonoBehaviour
{
    public void NextLevelMenu()
    {
        gameObject.SetActive(true);
    }
    public void NextLevelButton()
    {
        SceneManager.LoadScene("Main");
    }
}

