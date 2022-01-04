using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorControl : MonoBehaviour
{
    //componet make phis
    Rigidbody rigitBody;
    public float Speed_actor = 25f;
    //
    

       void Start()
    {
        Application.targetFrameRate = 30;
        
        //phis initialized
        rigitBody = GetComponent<Rigidbody>();
        //
    }
        
    void Update()
    {

        //pls set vector for key press

        if (Input.GetKeyDown(KeyCode.W))//for move all forward=> left;righ,back
        {  
    
            //transform.position+=transform.forward * Speed_actor * Time.deltaTime;
            rigitBody.AddForce( transform.forward * Speed_actor *  Time.deltaTime);//* Time.deltaTime;
    
        } 

        //exit
        if (Input.GetKeyDown(KeyCode.Space))//Escape
        {
             Application.Quit();//or other_menu
        }
        //fix code

    }

 
}
