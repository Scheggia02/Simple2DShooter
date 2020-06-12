using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 m = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        m.z = 1.0f;
       Vector3 c = m - transform.position;
       transform.position = c + transform.position;
    }
}
