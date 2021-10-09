using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinEnd : MonoBehaviour
{

    float spin = 100.0f;

 public void OnTriggerEnter(Collider collide)
    {
        Destroy(gameObject);
    }

    public void Update()
    {
        transform.Rotate(0.0f, 0.0f, spin * Time.deltaTime);
    }
}
