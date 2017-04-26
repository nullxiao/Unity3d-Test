using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateEnemy : MonoBehaviour {
    private float createTime = 100f;
    public GameObject createEnemy;
	void Update () {
        createTime += Time.deltaTime;
        if(createTime >= 0.75f)
        {
            for (int i=0; i < 3; i++){
                float temp = Random.Range(-5.31f, 5.31f);
                Instantiate(createEnemy).transform.position = new Vector3(temp, 8, -10);
            }
                createTime = 0;

        }
	}
}
