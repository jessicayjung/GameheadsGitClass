using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class PickUp : MonoBehaviour
{
    public TMP_Text scoretext;
    private int score;

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        scoretext.text = score.ToString();
        Debug.Log("Object Entered Trigger.");
        Object.Destroy(this);
        
    }
}
