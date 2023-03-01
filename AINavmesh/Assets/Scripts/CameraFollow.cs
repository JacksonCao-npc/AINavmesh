using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 cameraOffSet;
    public Transform cameraPos;
    public Transform playerPos;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        cameraPos.position = playerPos.position + cameraOffSet;
        transform.position = cameraPos.position;

        
    }
}
