using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float waitTime = 1;
    public float speed = 5f;
    public Vector3 positionDelta = Vector3.zero;

    private Vector3 _closedPosition;
    private Vector3 _openPosition;

    private void Start()
    {
        _closedPosition = transform.position;
        _openPosition = _closedPosition + positionDelta;

        Debug.Log("before co");
        StartCoroutine(OpenClose());
        Debug.Log("after log");

    }


    IEnumerator OpenClose()
    {
        Vector3 goal = _openPosition;
        bool isOpen = false;
        Debug.Log("Start co");
        
        Debug.Log("wait 3 sec");
        while (true)
        {
            if (Vector3.Distance(transform.position, goal) < 0.1f)
            {
                isOpen = !isOpen;
                if(isOpen)
                {
                    goal = _closedPosition;
                }
                else
                {
                    goal = _openPosition;
                }
             
                yield return new WaitForSeconds(waitTime);
            }
            else
            {

                transform.position = Vector3.MoveTowards(transform.position, goal, speed * Time.deltaTime);
                yield return null;
            }
        }


    }


}
