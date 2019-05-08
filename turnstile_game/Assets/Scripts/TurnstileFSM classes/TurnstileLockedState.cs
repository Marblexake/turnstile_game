using UnityEngine;
using System.Collections;

public class TurnstileLockedState : TurnstileState
{
    public TurnstileLockedState(TurnstileFSMClass turnstile)
    {
        // m_turnstile inherited from TurnstileState
        m_turnstile = turnstile;
    }

    public override void Enter()
    {
        Debug.Log("Entering locked state.");
    }

    public override void Execute()
    {
        if (checkCoin())
        {
            Debug.Log("You just inserted a coin.");

            if (!CheckCoinDropped())
            {
                // newState inherited from TurnstileState
                newState = new TurnstileBrokenState(m_turnstile);
            }
            else
            {
                releaseTurnstile();
                newState = new TurnstileUnlockedState(m_turnstile);
            }

            m_turnstile.ChangeState(newState);
        }
        else
        {
            Debug.Log("Please insert a coin.");
        }
    }

    public override void Exit()
    {
        Debug.Log("Exiting locked state.");
    }

    bool checkCoin()
    {
        if(Random.Range(0,10) >= 8f)
        {
            return true;
        }
        return false;
    }

    private bool CheckCoinDropped()
    {
        if (Random.Range(0, 10) >= 7f) // 7 is just an example number
        {
            return true;
        }
        return false;
    }

    void releaseTurnstile()
    {
        Debug.Log("Turnstile unlocked!");
    }

}

