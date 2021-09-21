using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mover el vehiculo
        //this.transform.Translate(0,0,1);
        this.transform.Translate(Vector3.forward);// es lo mismo que (0,0,1)
    }  
}
