using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnstileUnlockedState : TurnstileState {

    public TurnstileUnlockedState(TurnstileFSMClass turnstile)
    {
        m_turnstile = turnstile;
    }

    public override void Enter()
    {
        Debug.Log("Entering unlocked state.");
    }

    public override void Execute()
    {
        if (checkPush())
        {
            pushTurnstile();
            newState = new TurnstileLockedState(m_turnstile);
        }
        else
        {
            Debug.Log("Please push the turnstile.");
            newState = new TurnstileUnlockedState(m_turnstile);
        }
        m_turnstile.ChangeState(newState);

    }

    public override void Exit()
    {
        Debug.Log("Exiting unlocked state.");
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
}
