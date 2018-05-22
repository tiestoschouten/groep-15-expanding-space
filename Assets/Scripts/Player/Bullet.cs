using UnityEngine;

public class Bullet : MonoBehaviour {

    public float bulletVelocity = 0.6f;


    void Update ()
    {
        transform.Translate(new Vector3(0f, bulletVelocity, 0f));
        if ((transform.position.y > 20) || (transform.position.x > 20) || (transform.position.x < -20)){
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Cube")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
