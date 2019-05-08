using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnstileBrokenState : TurnstileState {

    public TurnstileBrokenState(TurnstileFSMClass turnstile)
    {
        m_turnstile = turnstile;
    }

    public override void Enter()
    {
        Debug.Log("Entering Broken state.");
    }

    public override void Execute()
    {
        Debug.Log("Coin is stuck.");
        Repair();
        m_turnstile.ChangeState(newState);

    }

    public override void Exit()
    {
        Debug.Log("Exiting Broken State.");
    }

    void Repair()
    {
        Debug.Log("The turnstile has been repaired!");
        newState = new TurnstileLockedState(m_turnstile);
    }
}
