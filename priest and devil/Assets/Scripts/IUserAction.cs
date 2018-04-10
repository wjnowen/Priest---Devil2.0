using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { WIN, FAILED, NOT_ENDED }

public interface IUserAction
{
    void MoveBoat();
    void GameOver();
    void Restart();
    GameState getGameState();
}