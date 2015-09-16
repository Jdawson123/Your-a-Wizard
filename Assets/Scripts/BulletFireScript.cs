using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletFireScript : MonoBehaviour 
{
	public float fireTime = 1.0f;
	public Transform Spawn;
	
	void Update () 
	{
		if (Input.GetButtonDown ("Fire1")) 
		{
			Fire();
		}

	}
	

	void Fire () 
	{
		GameObject obj = NewObjectpoolerScript.current.GetPooledObject ();
		if (obj == null)
			return;

		obj.transform.position = Spawn.transform.position;
		obj.transform.eulerAngles = new Vector3 (transform.rotation.x, 0, 0);
		obj.SetActive(true);

		obj.GetComponent<Rigidbody> ().AddForce (transform.localPosition * 500);



	}
}
