using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerMove : MonoBehaviour {
    [SerializeField] NavMeshAgent navMeshAgent1;
    [SerializeField] Transform movePositionTransform1;
    /* void Start () {
         //navMeshAgent = GetComponent<NavMeshAgent> ();
     }*/

    void Update () {
        navMeshAgent1.SetDestination (movePositionTransform1.position);
    }
}