﻿using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {
    public Camera camera;

    void Start(){
        
    }

	void Update() {
		RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit)) {
            Transform objectHit = hit.transform;
			Debug.Log(hit.point.x);
            
            // Do something with the object that was hit by the raycast.
        }
	}
}