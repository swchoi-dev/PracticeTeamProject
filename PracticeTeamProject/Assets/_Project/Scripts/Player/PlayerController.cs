using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private StateMachine<PlayerContext> _stateMachine;
	private PlayerContext _context;
	private PlayerInput _input;

	private void Awake()
	{

		Dictionary<StateType, StateBase<PlayerContext>> stateDict = new();

		stateDict[StateType.Attack] = new AttackState(_context);
		stateDict[StateType.Walk] = new WalkState(_context);
		stateDict[StateType.Attack] = new AttackState(_context);

		// stateDict[StateType.Walk] = new WalkState();

		_stateMachine = new StateMachine<PlayerContext>(stateDict);
	}

	private void Start()
	{
		_stateMachine.ChangeState(StateType.Walk);
	}

    private void Update()
    {
		_input.Read();

		_stateMachine.Tick();
    }

    private void FixedUpdate()
    {
	    _stateMachine.FixedTick();
    }

    private void OnAnimEvent(string animName)
    {
	    _stateMachine.OnAnimEvent(animName);
    }
}
