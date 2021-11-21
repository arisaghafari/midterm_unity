using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneManager : MonoBehaviour
{
    public CameraManager camera;

    private void Start()
    {
        transform.position = new Vector3(transform.position.x, camera.transform.position.y - 6, transform.position.z);
    }
    void Update()
    {
        //float v = (camera.transform.position.y - 6);
        //transform.localScale = new Vector3(transform.localScale.x, , transform.localScale.z);
        transform.position = new Vector3(transform.position.x, camera.transform.position.y - 6, transform.position.z);
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
