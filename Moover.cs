using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moover : MonoBehaviour
{
void Moove()
{
 transform.position += Vector3.Down * speed * Time.deltaTime;
}
public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
