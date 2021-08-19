using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable_Green : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameController gc;
        int gemValueGreen = 20;


        if (other.gameObject.CompareTag("Player"))
        {

            gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
            gc.changeScore(gemValueGreen);




            Destroy(this.gameObject);
            Debug.Log("Enter collider gem");
        }


    }

}


