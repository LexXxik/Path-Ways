using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void OnClickF()
    {
        GameObject.Find("MManager").GetComponent<MemberScript>().FavouriteO = this.gameObject;
        GameObject.Find("MManager").GetComponent<MemberScript>().OnClickFavourite();
    }
}
