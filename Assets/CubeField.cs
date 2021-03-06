﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CubeField : MonoBehaviour {

    public Transform prefabelement;
    public float spacing;
    public int w;

    // Use this for initialization
    void Start () {
        Transform foo;
        float mid = spacing * w / 2;
        for (int i = 0; i < w; i++)
        {
            for(int j = 0; j < w; j++)
            {
                for (int k = 0; k < w; k++)
                {
                    foo = Instantiate(prefabelement, transform);
                    foo.position = new Vector3(Random.Range(-spacing/3,spacing/3)+spacing * i - mid, Random.Range(-spacing / 3, spacing / 3) + spacing * j - mid, Random.Range(-spacing / 3, spacing / 3) + spacing * k - mid);
                    foo.rotation = Random.rotation;
                    foo.localScale = Random.Range(.7f, spacing / 10)*Vector3.one;
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {

	}
}
