﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
	int score = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision hit)
    {
    	if(hit.gameObject.tag== "enemy")
    	{
    		score = score + 1;
    		print(score);
    		if(score == 3){
    			Destroy(hit.gameObject);
    			FindObjectOfType<move>().PlayVictory();
    		}
    	}
    }
}
