using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f);

		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.1f);
		}

	}

	private void onTriggerEnter(Collider other) {
		Debug.Log("On trigger");

	}
	private void onCollisionEnter(Collision other) {
		Debug.Log("On colission");
	}
}
