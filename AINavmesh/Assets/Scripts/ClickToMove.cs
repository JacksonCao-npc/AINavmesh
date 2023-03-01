using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class ClickToMove : MonoBehaviour
{
    NavMeshAgent _agent;
    RaycastHit _hitInfo = new RaycastHit();


    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out _hitInfo, Mathf.Infinity))
        {
            _agent.destination = _hitInfo.point;

            Debug.DrawLine(Camera.main.transform.position, _hitInfo.point);
        }
    }
    
}
