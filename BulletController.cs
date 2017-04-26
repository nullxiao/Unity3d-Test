using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    private float speed = 5.5f;
    public GameObject dieAnim;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "enemy")
        {
            Destroy(other.gameObject);
            Instantiate(dieAnim, other.transform.position, other.transform.rotation);
        }
    }
    void Update () {
        transform.Translate(0, Time.deltaTime*speed, 0);
        if(transform.position.y >= 7)
        {
            Destroy(gameObject);
        }
	}
}
