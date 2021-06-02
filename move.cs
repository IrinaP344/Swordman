  wusing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
	float v;
	Rigidbody rb;
	Animator anim;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody>();
         anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");
        rb.velocity = transform.forward * v * 2f;

        if(v!=0)
        {
        	anim.SetBool("isWalk", true);
        }else
        {
        	anim.SetBool("isWalk", false);
        }
       
      	if(Input.GetMouseButtonDown(0))
      	{
      		anim.SetTrigger("attack");
      	}

    }
    public void PlayVictory()
      	{
      		anim.SetTrigger("victory");
      	}
}
