using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyBean : MonoBehaviour
{
    public GameObject jellyPrefab;


    private void Update()
    {
        Instantiate(jellyPrefab, transform.position, transform.localRotation);
    }
}
