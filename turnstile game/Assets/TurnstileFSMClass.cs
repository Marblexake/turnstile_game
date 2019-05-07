using UnityEngine;
using System.Collections;

public class /* code missing */ : MonoBehaviour
{

    TurnstileState m_LockedState = null;
    /* code missing */
    /* code missing */
    /* code missing */

    void Start()
    {
        m_LockedState = new TurnstileLockedState(/* code missing */);
        /* code missing */
        /* code missing */
        /* code missing */
        /* code missing */
    }

    void Update()
    {
        /* code missing */
    }

    public void ChangeState(/* code missing */)
    {
        if (m_CurrentState != null)
        {
            m_CurrentState.Exit();
        }

        m_CurrentState = nextState;
       /* code missing */
    }
}

