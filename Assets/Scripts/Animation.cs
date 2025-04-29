using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void animation_end()
    {
        GetComponent<Animator>().SetBool("damaged", false);
    }

    public void DEAD()
    {
        FindObjectOfType<Enemy>().DEAD();
    }

}
