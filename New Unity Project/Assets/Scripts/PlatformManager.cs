using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    private void Update()
    {
        Debug.Log(this.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("death zone"))
        {
            Debug.Log("death zone -- platform");
            Destroy(this.gameObject);
        }
    }
}
