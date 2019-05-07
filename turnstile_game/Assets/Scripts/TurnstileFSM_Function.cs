using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnstileFSM_Function : MonoBehaviour
{
    enum StateEnum
    {
        locked,
        unlocked,
        broken
    }

    StateEnum state;

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case StateEnum.locked:
                stateLocked();
                break;
            case StateEnum.unlocked:
                stateUnlocked();
                break;
            case StateEnum.broken:
                stateBroken();
                break;
            default:
                Debug.Log("ERROR - no valid State!");
                break;
        }
    }

    void stateBroken()
    {
        Debug.Log("Coin is stuck!");
        Repair();
    }

    void stateLocked()
    {
        if (checkCoin())
        {
            if (CheckCoinDropped())
            {
                releaseTurnstile();
                state = StateEnum.unlocked;
            }
            else
            {
                state = StateEnum.broken;
            }
        }
    }

    void stateUnlocked()
    {
        if (checkPush())
        {
            pushTurnstile();
            state = StateEnum.locked;
        }
    }

    void Repair()
    {
        Debug.Log("The turnstile has been repaired!");
        state = StateEnum.locked;
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

    bool CheckCoinDropped()
    {
        if (Random.Range(0, 10) >= 2f)
        {
            return true;
        }
        return false;
    }

    void pushTurnstile()
    {
        Debug.Log("You have pushed!!");
    }

    void releaseTurnstile()
    {
        Debug.Log("Turnstile unlocked!");
    }
}
