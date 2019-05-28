using UnityEngine;
using System.Collections;

public abstract class TurnstileState {

    protected TurnstileFSMClass m_turnstile = null;
    protected TurnstileState newState = null;

	public virtual void Enter()
    {

    }

    public virtual void Execute()
    {

    }

    public virtual void Exit()
    {

    }

}

