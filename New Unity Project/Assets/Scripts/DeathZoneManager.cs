using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneManager : MonoBehaviour
{
    public CameraManager camera;
    void Update()
    {
        transform.position = new Vector3(transform.position.x, camera.transform.position.y - 6, transform.position.z);
        //Debug.Log(transform.position.y);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            Debug.Log("platform");
            Destroy(gameObject);
        }
    }
}
