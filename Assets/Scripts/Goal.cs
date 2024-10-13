using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Aim")
        {
            Destroy(gameObject,.5f);
            SceneManager.LoadScene("MainMenuScreen");
        }
    }

}
