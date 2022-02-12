using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    // Start is called before the first frame update
    public void MoveToScene(int id)
    {
        calScore.scoreV = 0;
        SceneManager.LoadScene(id);
    }
}
