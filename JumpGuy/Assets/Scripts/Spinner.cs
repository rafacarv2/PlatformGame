using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	private float multiplicador = 1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime*multiplicador, Space.World);
	}
}
