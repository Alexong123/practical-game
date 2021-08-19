using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable_Blue : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameController gc;
        int gemValueBlue = 30;


        if (other.gameObject.CompareTag("Player"))
        {

            gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
            gc.changeScore(gemValueBlue);




            Destroy(this.gameObject);
            Debug.Log("Enter collider gem");
        }


    }

}


