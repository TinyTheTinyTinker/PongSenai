using Assets.Scripts;
using NUnit.Framework;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;

    public float ballTimeElapsed = 0f;

    public void StartGame()
    {
        foreach (var player in GameObject.FindGameObjectsWithTag("Player"))
        {
            if (player.GetComponent<SecondPlayerInput>() != null)
            {
                if (GameSettings.multiplayer)
                {
                    player.GetComponent<SecondPlayerInput>().enabled = true;
                    player.GetComponent<BotIA>().enabled = false;
                }

                else
                {
                    player.GetComponent<SecondPlayerInput>().enabled = false;
                    player.GetComponent<BotIA>().enabled = true;
                }
            }
        }
    }


    public void SetMultiplayer(bool isMultiplayer)
    {
        GameSettings.multiplayer = isMultiplayer;
    }

    public void CheckBallCollision()
    {
        if (ballTimeElapsed >= 3f)
        {

        }
    }
}