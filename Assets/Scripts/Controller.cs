using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{   
    private void Awake()
    {
        // View.startRepeatAnimation();
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {

            FindObjectOfType<Model>().birdMove();
        }
    }

}
