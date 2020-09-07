using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallUsingCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    	if(transform.position.y > 0.6f){
    		transform.Translate(0,-3.0f*Time.deltaTime,0,Space.World);

    	}
        
    }
}
