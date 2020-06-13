using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        Vector3 m = Camera.main.ScreenToWorldPoint(Input.mousePosition);  //Get mouse pos and convert from screen to world space
        m.z = 1.0f; //Set the Z pos at 1 to stay the sprite on top of the background
        Vector3 dir = m - transform.position; // Get direction from player pos to mouse pos
        
        transform.position += dir; // Teleport player to mouse pos

        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg; // Calculate the angle to apply on the Z axis to look at the mouse
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); // Rotate the player to mouse pos
    }
}
