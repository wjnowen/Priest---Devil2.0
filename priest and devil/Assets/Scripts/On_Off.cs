using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Off : MonoBehaviour
{

 
    private FirstSceneControl firstSceneControl;

    void Start()
    {
        firstSceneControl = (FirstSceneControl)Director.getInstance().currentSceneControl;
    }


    private void OnMouseDown()
    {
        int id = Convert.ToInt32(this.name);
        if (firstSceneControl.b_state != FirstSceneControl.BoatState.MOVING)
        {
            if (firstSceneControl.actionManager.on_off.ContainsKey(id)) firstSceneControl.actionManager.on_off[id].enable = true;
            if (firstSceneControl.actionManager.on_off.ContainsKey(id - 6)) firstSceneControl.actionManager.on_off[id - 6].enable = true;
        }

    }
}