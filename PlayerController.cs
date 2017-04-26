using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour {
    private float speed = 5.5f;
    public GameObject bulletGO;
    private float myTime = 0.2f;
    public Text textHP;
    private int playerHP = 2;
    public GameObject dieAnim;
    void Start()
    {
        textHP.text = "生 命 值 —— " + playerHP;

    }
    public static void setPosition(GameObject go)
    {
        if (go.transform.position.x <= -5.31f)
        {
            go.transform.position = new Vector3(-5.3f, go.transform.position.y, go.transform.position.z);
        }
        else if (go.transform.position.x >= 5.31f)
        {
            go.transform.position = new Vector3(5.3f, go.transform.position.y, go.transform.position.z);
        }

        if (go.transform.position.y <= -4)
        {
            go.transform.position = new Vector3(go.transform.position.x, -3.99f, go.transform.position.z);
        }
        else if (go.transform.position.y >= 4)
        {
            go.transform.position = new Vector3(go.transform.position.x, 3.99f, go.transform.position.z);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "enemy")
        {
            Destroy(other.gameObject);
            Instantiate(dieAnim, other.transform.position, other.transform.rotation);
            textHP.text = "生 命 值 —— " + --playerHP;
            if(playerHP < 0)
            {
                textHP.text = "我  就  测  试  一  下  这  玩  意  做  游  戏  有  多  难  (  或  简  单  )\n哈  哈  哈  哈";
            }
        }
    }

    void Update () {
        myTime += Time.deltaTime;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(x*Time.deltaTime*speed,y*Time.deltaTime*speed, 0);
        setPosition(gameObject);
        if (Input.GetKeyDown(KeyCode.K) && myTime >=0.3f)
        {

            GameObject bullet1 = Instantiate(bulletGO);
            GameObject bullet2 = Instantiate(bulletGO);
            GameObject bullet3 = Instantiate(bulletGO);
            bullet1.transform.position = new Vector3(transform.position.x, transform.position.y + 1.2f, transform.position.z);

            bullet2.transform.Rotate(0,0,-30);
            bullet2.transform.position = new Vector3(transform.position.x+1.2f, transform.position.y + 1.2f, transform.position.z);

            bullet3.transform.Rotate(0, 0, 30);
            bullet3.transform.position = new Vector3(transform.position.x - 1.2f, transform.position.y + 1.2f, transform.position.z);

            myTime = 0;
        }
	}
}
