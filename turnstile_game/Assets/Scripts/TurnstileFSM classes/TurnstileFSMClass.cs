using UnityEngine;
using System.Collections;

public class TurnstileFSMClass : MonoBehaviour
{

    TurnstileState m_LockedState = null;
    TurnstileState m_UnlockedState = null;
    TurnstileState m_BrokenState = null;
    TurnstileState m_CurrentState = null;

    void Start()
    {
        m_LockedState = new TurnstileLockedState(this);
        m_UnlockedState = new TurnstileUnlockedState(this);
        m_BrokenState = new TurnstileBrokenState(this);
        m_CurrentState = m_LockedState;
    }

    void Update()
    {
        m_CurrentState.Execute();
    }

    public void ChangeState(TurnstileState nextState)
    {
        if (m_CurrentState != null)
        {
            m_CurrentState.Exit();
        }

        m_CurrentState = nextState;
        m_CurrentState.Enter();
    }
}

