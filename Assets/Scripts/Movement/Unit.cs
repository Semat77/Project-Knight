using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Unit : MonoBehaviour
{

    public static Unit selectedUnit;

    private NavMeshAgent agent;
    
    
    void Start()
    {
        selectedUnit = this;
        agent = GetComponent<NavMeshAgent>();
    }

    public void MoveTo(Vector3 target){
        agent.SetDestination(target);
    }
}
