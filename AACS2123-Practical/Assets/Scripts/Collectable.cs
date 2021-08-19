using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameController gc;
        int gemValue = 10;
        

        if (other.gameObject.CompareTag("Player"))
        {

            gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
            gc.changeScore(gemValue);
            
            


            Destroy(this.gameObject);
            Debug.Log("Enter collider gem");
        }
        
     
    }

}


