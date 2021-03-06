﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour {

	public EntityController entityController;

	void OnTriggerEnter(Collider col) {
		string tag = col.gameObject.tag;
		if ((tag == "Enemy" || tag == "Building" || tag == "Player") && entityController.CheckAttack()) {
			(col.gameObject.GetComponent<EntityController>()).TakeDamage(1);
		}
	}
}
