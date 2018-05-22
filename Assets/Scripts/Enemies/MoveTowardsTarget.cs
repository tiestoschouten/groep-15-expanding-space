using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsTarget : MonoBehaviour {

    public GameObject target;

	// Update is called once per frame
	void Update ()
    {
        Vector3 direction = target.transform.position - transform.position;
        print(direction.normalized);
        transform.Translate(direction.normalized * Time.deltaTime);
	}
}
