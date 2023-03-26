using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotx, roty, rotz;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotx, roty, rotz);
    }
}
