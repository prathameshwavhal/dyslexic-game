using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchItem : MonoBehaviour
{
    public static int count = 0;
    private bool isDragging;
    //public GameObject levelWinUI;
     
    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);

        //Check to see if the tag on the collider is equal to selected
        if (other.tag == this.tag)
        {
            Message.count += 1;
            count = count + 1;
            calScore.scoreV += 0.5;
            // Destroy(other);
            gameObject.active = false;
        }


 
    }
}