using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour {
    private float animTime;
	void Update () {
        animTime += Time.deltaTime;
        if(animTime >= 0.9f)
        {
            Destroy(gameObject);
        }
    }
}
