using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour {
    public int scoreValue = 1;
    void OnMouseDown()
    {
        Destroy(gameObject);

        // Increase the score by the enemy's score value.
        ScoreManager.score += scoreValue;

    }
}
