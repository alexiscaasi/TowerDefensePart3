using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static float health = 3;
    public Text healthScore;

    void Start() {
        healthScore = GetComponent<Text>();
    }

    void Update() {
        healthScore.text = health.ToString("0");
    }
}
