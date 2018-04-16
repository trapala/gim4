using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<Collider>().CompareTag("Player") && GetComponent<Rigidbody>().angularDrag == 0.05f)
		{
			GetComponent<Rigidbody>().angularDrag = 0;
			AudioSource sound = other.GetComponent<AudioSource>();
			sound.Play();
		}
	}
}