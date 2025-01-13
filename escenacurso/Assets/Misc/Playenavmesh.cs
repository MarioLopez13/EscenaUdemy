using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Playenavmesh : MonoBehaviour {

    NavMeshAgent navMeshAgent;
    [SerializeField] Transform movePositionTransform;
    void Start () {
        navMeshAgent = GetComponent<NavMeshAgent> ();
    }

    void Update () {
        navMeshAgent.destination = movePositionTransform.position;
        //        navMeshAgent.SetDestination (movePositionTransform.position);
    }
}