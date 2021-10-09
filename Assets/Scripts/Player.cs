using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float counter;

    public float playerSpeed = 0.1f;
    public float playerRotation = 100.0f;

    public Rigidbody rb;

    public void Start()
    {
        counter = 0;
    }

    public void OnTriggerEnter(Collider collide)
    {
        counter += 1;
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * playerRotation * Time.deltaTime;

        transform.Translate(0, 0, translation);

        transform.Rotate(0, rotation, 0);

        if (counter == 11)
        {
            SceneManager.LoadScene("End");
        }
    }
 }
