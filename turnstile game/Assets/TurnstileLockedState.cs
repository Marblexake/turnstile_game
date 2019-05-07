using UnityEngine;
using System.Collections;

public class TurnstileLockedState : /* code missing */
{
    public TurnstileLockedState(/* code missing */)
    {
        // m_turnstile inherited from TurnstileState
        /* code missing */
    }

    public override void Enter()
    {
        /* code missing */
    }

    public override void Execute()
    {
        if (checkCoin())
        {
            Debug.Log("You just inserted a coin.");

            if (!CheckCoinDropped())
            {
                // newState inherited from TurnstileState
                /* code missing */
            }
            else
            {
                /* code missing */
            }

            /* code missing */
        }
        else
        {
            Debug.Log("Please insert a coin.");
        }
    }

    public override void Exit()
    {
        /* code missing */
    }

    bool checkCoin()
    {
        /* code missing */
    }

    private bool CheckCoinDropped()
    {
        if (Random.Range(0, 10) >= 7f) // 7 is just an example number
        {
            /* code missing */
        }
        /* code missing */
    }

}

