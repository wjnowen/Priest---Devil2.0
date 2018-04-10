using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCActionManager : SSActionManager, ISSActionCallback
{

    public FirstSceneControl sceneController;
    public CCMoveToAction moveToLeft, moveToRight;
    public Dictionary<int, CCOn_OffAction> on_off = new Dictionary<int, CCOn_OffAction>();

    protected new void Start()
    {
        float speed = 15f;
        sceneController = (FirstSceneControl)Director.getInstance().currentSceneControl;
        sceneController.actionManager = this;

   
        moveToLeft = CCMoveToAction.GetSSAction(sceneController.Boat_Left, speed);
        moveToRight = CCMoveToAction.GetSSAction(sceneController.Boat_Right, speed);
        foreach (KeyValuePair<int, GameObject> obj in sceneController.On_Shore_r)
        {
            on_off[obj.Key] = CCOn_OffAction.GetSSAction();
        }

   
        this.RunAction(sceneController.boat, moveToLeft, this);
        this.RunAction(sceneController.boat, moveToRight, this);
        foreach (KeyValuePair<int, GameObject> obj in sceneController.On_Shore_r)
        {
            this.RunAction(obj.Value, on_off[obj.Key], this);
        }

    }

    public void SSActionEvent(SSAction source,
        SSActionEventType events = SSActionEventType.Competeted,
        int intParam = 0,
        string strParam = null,
        Object objectParam = null)
    {

    }

}