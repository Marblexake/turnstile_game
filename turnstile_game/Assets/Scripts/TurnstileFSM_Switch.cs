using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnstileFSM_Switch : MonoBehaviour
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
                break;
            case StateEnum.unlocked:
                if (checkPush())
                {
                    pushTurnstile();
                    state = StateEnum.locked;
                }
                break;
            case StateEnum.broken:
                Debug.Log("Coin is stuck!");
                Repair();
                break;
            default:
                Debug.Log("ERROR - no valid State!");
                state = StateEnum.locked;
                break;
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
