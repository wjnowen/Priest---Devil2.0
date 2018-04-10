using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserGUI : MonoBehaviour
{
    private IUserAction action;

    void Start()
    {
        action = Director.getInstance().currentSceneControl as IUserAction;
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(240, 30, 100, 40), "开船") && action.getGameState() == GameState.NOT_ENDED)
        {
            action.MoveBoat();
        }
       
        if (action.getGameState() == GameState.WIN)
        {
            GUI.Label(new Rect(335, 100, 400, 100), "游戏获胜！");
            GUI.Button(new Rect(380, 30, 100, 40), "重新开始");
            GUI.color = Color.red;

        }
        if ((action.getGameState() == GameState.FAILED))
        {
            GUI.color = Color.red;
            GUI.Label(new Rect(335, 100, 400, 100), "游戏失败！");
            //action.GameOver();

        }
        if (GUI.Button(new Rect(380, 30, 100, 40), "重新开始"))
        {
            action.Restart();
        }
    }


}