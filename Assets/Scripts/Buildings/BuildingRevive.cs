﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingRevive : Building {
    
	
	// Update is called once per frame
	public override void FixedUpdate () {
        base.FixedUpdate();	
	}

    public override void ShowGUI()
    {
        GameHUDManager.instance.ShowInfoBox(this, "Revive", "This is an example text.");
    }


}
