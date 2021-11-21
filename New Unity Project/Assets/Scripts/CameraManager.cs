using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public DoodleMove doodle;
    void Update()
    {
        transform.position = new Vector3(transform.position.x, doodle.transform.position.y, transform.position.z);            
    }
}
