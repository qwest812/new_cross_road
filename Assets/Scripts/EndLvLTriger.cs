using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLvLTriger : MonoBehaviour
{

   [SerializeField] private GameObject winPanel; 
   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
          winPanel.SetActive(true);
      }
   }
}
