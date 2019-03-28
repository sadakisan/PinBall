using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeCloud : MonoBehaviour {

    public int scorePoint;


	void OnCollisionEnter(Collision collision)
    {
        Manager.score += scorePoint;
		
	}
}
