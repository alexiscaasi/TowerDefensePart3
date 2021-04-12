using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wp7 : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) {
        Health.health -= 1;
        if(Health.health == 0) {
            SceneManager.LoadScene("RestartMenu");
        }
    }
}
