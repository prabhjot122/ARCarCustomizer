using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Rotate : MonoBehaviour
{

    // Update is called once per frame
    public Vector3 rot;

    void Update()
    {
        transform.Rotate(rot*Time.deltaTime);
    }
}
