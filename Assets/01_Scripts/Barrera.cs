using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Barrera : MonoBehaviour
{
    public Transform Objetivo;
    //public float Velocidad;
    public NavMeshAgent IA;

    void Update()
    {
        IA.SetDestination(Objetivo.position);
    }
    /*  public Transform jugador;
      NavMeshAgent enemigo;
      private bool dentro = false;

      void Start()
      {
          enemigo = GetComponent<UnityEngine.AI.NavMeshAgent>();
      }
       void OnTriggerEnter(Collider other)
      {
          if (other.tag == "Player")
          {
              dentro = true;
          }
      }
      void OnTriggerExit(Collider other)
      {
          if (other.tag == "Player")
          {
              dentro = false;
          }
      }
      void Update()
      {
          if (!dentro)
          {
              enemigo.destination = jugador.position;
          }
          if (dentro)
          {
              enemigo.destination = this.transform.position;
          }
      }*/
}
