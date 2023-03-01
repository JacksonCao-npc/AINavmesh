using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiPetrol : MonoBehaviour
{

    
    public Transform[] wayPoints;
   
    private NavMeshAgent _agent;
    public int wayPointsIndex;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        wayPointsIndex = Random.Range(0, 2);
        
    }

    // Update is called once per frame
    void Update()
    {

        _agent.destination = wayPoints[wayPointsIndex].position;
        if (Vector3.Distance(_agent.transform.position,wayPoints[wayPointsIndex].position)<1f)
        {
            wayPointsIndex += 1;
            if(wayPointsIndex ==2)
            {
                wayPointsIndex = 0;
            }
        }

       
        
    }
}
