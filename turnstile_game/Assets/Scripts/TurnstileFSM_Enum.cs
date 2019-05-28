using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnstileFSM_Enum : MonoBehaviour
{
    enum StateEnum
    {
        locked,
        unlocked
    }

    StateEnum state;

    // Update is called once per frame
    void Update()
    {

        if (state == StateEnum.locked)
            if (checkCoin())
            {
                releaseTurnstile();
                state = StateEnum.unlocked;
            }
            else
            {
                Debug.Log("You need a coin!");
            }
        else if (state == StateEnum.unlocked)
        {
            if (checkPush())
            {
                pushTurnstile();
                state = StateEnum.locked;
            }
            else
            {
                Debug.Log("Give a push");
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
        Debug.Log("You have pushed!!");
    }

    void releaseTurnstile()
    {
        Debug.Log("You have inserted a coin! Turnstile unlocked!");
    }
}
