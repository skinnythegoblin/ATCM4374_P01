using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupState : State
{
    GameSM _stateMachine;
    GameController _controller;

    public SetupState(GameSM sm, GameController controller)
    {
        _stateMachine = sm;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entered SetupState");

        if (_stateMachine.PreviousState != this)
        {
            _controller.StartGame();
        }

        _controller.Dice_Tray.SetBounds(Screen.width, Screen.height);
        _controller.Resource_Manager.SetInitial();
        _controller.DisplayWinPanel(false);
        _controller.DisplayLosePanel(false);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Tick()
    {
        base.Tick();
        _stateMachine.ChangeState<PlayState>();
    }
    
    public override void FixedTick()
    {
        base.FixedTick();
    }
}
