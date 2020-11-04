using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidePunch : MonoBehaviour
{
    public Punch punchobj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (punchobj.punching)
        {
            Debug.Log("JE FRAPPE");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && punchobj.punching)
        {
            // en gros il faut appeler le component de vie et lui modifier sa valeur...
            // var life = other.gameObject.GetComponent<Life>();  
            // life.end = life.end - 10;
        }
    }

}
