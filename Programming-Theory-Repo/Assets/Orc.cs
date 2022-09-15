using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Sphere a = new Sphere(30.5f, 2.4f);
        Cube b = new Cube(13f, 3f);
        Cylinder c = new Cylinder(14f, 2.3f, 5.6f);

        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);

        a.Move();
        b.Move();
        c.Move();

        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
