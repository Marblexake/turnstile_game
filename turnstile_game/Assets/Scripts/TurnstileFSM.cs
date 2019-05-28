using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnstileFSM : MonoBehaviour
{
    string state = " ";

    void Start()
    {
        state = "locked";
    }

    void Update()
    {
        if (state == "locked")
        {
            if (checkCoin())
            {
                releaseTurnstile();
                state = "unlocked";
            }
            else
            {
                Debug.Log("You need a coin!");
            }
        }
        else if (state == "unlocked")
        {
            if (checkPush())
            {
                pushTurnstile();
                state = "locked";
            }
            else
            {
                Debug.Log("Give a push!");
            }
        }
    }

    bool checkCoin()
    {
        if (Random.Range(0, 10) >= 8f)
        {
            return true;
        }
        return false;
    }

    bool checkPush()
    {
        if (Random.Range(0, 10) >= 3f)
        {
            return true;
        }
        return false;
    }

    void pushTurnstile()
    {
        Debug.Log("You have pushed through the turnstile!!");
    }

    void releaseTurnstile()
    {
        Debug.Log("You have inserted a coin! Please push the turnstile.");
    }
}
