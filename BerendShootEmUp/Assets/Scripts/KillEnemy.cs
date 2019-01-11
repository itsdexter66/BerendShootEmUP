using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour {

    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
