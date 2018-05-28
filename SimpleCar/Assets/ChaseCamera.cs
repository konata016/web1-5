using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour {

    public GameObject PL;
    public int My_y = 3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 camera = this.transform.position;

        camera.x = PL.transform.position.x;
        camera.y = PL.transform.position.y + My_y;
        camera.z = PL.transform.position.z - 10;

        transform.position = camera;
    }
}
