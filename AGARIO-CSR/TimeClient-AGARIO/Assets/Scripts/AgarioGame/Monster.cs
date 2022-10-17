using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
   public string Tag;
   public float Increase;
   public Text Letters;

   int Score = 0;
   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.tag == Tag)
      {
         transform.localScale += new Vector3(Increase, Increase, Increase);
         
         Destroy(other.gameObject);

         Score += 10;
         Letters.text = "SCORE: " + Score;
      }
   }
}
