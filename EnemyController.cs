
using UnityEngine;
using UnityEngine.UI;
public class EnemyController : MonoBehaviour {
    private float speed = 5.6f;
    private float enemyTime;
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
       if(other.tag == "bullet")
        {
            Destroy(other.gameObject);
        }
    }
    void Update() {
        transform.Translate(0, -Time.deltaTime * speed, 0);
        if (transform.position.y < -6.5f)
        {
            Destroy(gameObject);
        }
    }
}
