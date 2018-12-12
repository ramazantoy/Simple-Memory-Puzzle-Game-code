﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButonEkle : MonoBehaviour {
   

    [SerializeField]
    private Transform puzzleField;
    [SerializeField]
    private GameObject btn;

	void Awake() {
        for(int i = 0; i <= 13; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(puzzleField,false);
        }
		
	}
	
}
