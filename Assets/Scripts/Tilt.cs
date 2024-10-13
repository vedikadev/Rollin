using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tilt : MonoBehaviour
{
    public Vector3 currentRot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentRot = GetComponent<Transform>().eulerAngles;
        if (( Input.acceleration.x<.2 ) && (currentRot.z <=10 || currentRot.z >=348 ) )
        {
            transform.Rotate(0, 0, (float)1.0);
        }
        if ((Input.acceleration.x > -.2) && (currentRot.z >= 349 || currentRot.z <= 11))
        {
            transform.Rotate(0,0,-(float)1.0);
        }
        if ((Input.acceleration.y > .2) && (currentRot.x <= 10 || currentRot.x >= 348))
        {
            transform.Rotate((float)1.0, 0, 0);
        }
        if ((Input.acceleration.y < -.2) && (currentRot.x >= 349 || currentRot.x <= 11))
        {
            transform.Rotate(-(float)1.0, 0,0);
        }
    }

    void OnTriggerExit(Collider other)
    {
        SceneManager.LoadScene("MainMenu");
    }
}
