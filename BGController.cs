using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour {
    private float speed = 3.5f;
    private Vector3 bg1v;
    void Start()
    {
        bg1v = GameObject.Find("bg (1)").transform.position;
    }
	void Update () {
        if(transform.position.y <= -61.3f) {
            transform.position = bg1v;
        }
        transform.Translate(0, -Time.deltaTime*speed, 0);
	}
}
