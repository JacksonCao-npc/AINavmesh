using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    



    // Update is called once per frame
void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Camera camera = Camera.main;
        Vector3 forward = camera.transform.forward;
        Vector3 right = camera.transform.right;

      
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        Vector3 desiredMoveDirection = (forward * vertical) + (right *horizontal);
        desiredMoveDirection.Normalize();
        transform.position += desiredMoveDirection * speed * Time.deltaTime;
    }
}
