﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        this.transform.LookAt(Camera.main.transform);
	}
}
