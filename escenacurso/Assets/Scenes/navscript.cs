using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navscript : MonoBehaviour {
    [SerializeField] NavMeshAgent navMeshAgent;
    [SerializeField] Transform movePositionTransform;
    /* void Start () {
         //navMeshAgent = GetComponent<NavMeshAgent> ();
     }*/

    void Update () {
        navMeshAgent.SetDestination (movePositionTransform.position);
    }
}