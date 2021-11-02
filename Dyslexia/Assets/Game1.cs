using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game1 : MonoBehaviour
{
    public void ExitPress()
    {
        SceneManager.LoadScene(0);
    }
}