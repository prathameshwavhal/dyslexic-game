using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{
    // Start is called before the first frame update
            Text score1;
   public static int count = 0;
    void Start()
    {
        score1 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Count :");
        Debug.Log(count);
        if (count == 3)
        {
            score1.text = "Score ";
        }

    }
 
}
