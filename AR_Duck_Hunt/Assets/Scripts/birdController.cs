using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour {

    private Transform targetFocus;

	// Use this for initialization
	void Start () {
        targetFocus = GameObject.FindGameObjectWithTag("Target").transform;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 target = targetFocus.position - this.transform.position;
        Debug.Log(target.magnitude);

        transform.LookAt(targetFocus);
        float speed = Random.Range(15f, 30f);
        transform.Translate(0,0, speed * Time.deltaTime);
	}
}