using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Video;
public class PlayerMove : MonoBehaviour
{
    public float speed = 2f;
    public bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame

    void Update()
    {
        // Move forward when Default GearVR button pressed
        if (Input.GetButton("Fire1"))
        {
			Vector3 cameraForward = Camera.main.transform.forward;
			this.gameObject.transform.Translate(cameraForward * Time.deltaTime * speed);
			// transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        }
    }

}
