﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceMesure : MonoBehaviour {

    public Transform player;
    public Text text;


	
	// Update is called once per frame
	void Update () {
        text.text = player.position.z.ToString("0");
	}
}
