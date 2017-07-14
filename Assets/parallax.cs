using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour {
    public Transform self;
    public Transform cam;
    private float radius;
    public float exaggerator;  // A value for modifying how pronounced the parallax effect is.

	// Use this for initialization
	void Start () {
        radius = (self.localScale.x /2) * exaggerator;
	}
	
	// Update is called once per frame
	void Update () {
        self.rotation = Quaternion.Euler(cam.rotation.x * -radius, cam.rotation.y * -radius, cam.rotation.z * -radius);
    }
}
