using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {

    public GameObject projectile;
    private float fireRate = 0.25f;

	// Update is called once per frame
	void Update ()
    {
        fireRate -= Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && fireRate <= 0)
        {
            ShootBullet();
            fireRate = 0.25f;
        }

	}

    public void ShootBullet()
    {
        var shoot = Instantiate(projectile, new Vector2(transform.position.x,transform.position.y), Quaternion.identity);
        shoot.transform.rotation = transform.rotation;
    }

    
}
