using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody _rigidbody;
	private Transform _transform;
	private Animator _animator;
	private Camera _camera;

	private StateMachine<PlayerContext> _stateMachine;
	private PlayerContext _context;
	private PlayerInput _input;

	// ----------- 이벤트 함수 --------------------
	private void Awake()
	{
		CacheComponents();
		BindContext();
		InitStateMachine();
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

    // ----------- 이벤트 함수 --------------------


    private void CacheComponents()
    {
	    _animator = GetComponent<Animator>();
	    _camera = GetComponentInChildren<Camera>();
	    _rigidbody = GetComponent<Rigidbody>();
	    _transform = GetComponent<Transform>();
    }

    private void BindContext()
    {
	    _context.camera = _camera;
	    _context.rigidbody = _rigidbody;
	    _context.transform = _transform;
	    _context.input = _input;
    }

    private void InitStateMachine()
    {
	    _stateMachine = new StateMachine<PlayerContext>();

	    Dictionary<StateType, StateBase<PlayerContext>> stateDict = new();

	    stateDict[StateType.Attack] = new AttackState(_context, _stateMachine);
	    stateDict[StateType.Walk] = new WalkState(_context, _stateMachine);
	    stateDict[StateType.Attack] = new AttackState(_context, _stateMachine);
    }

    private void OnAnimEvent(string animName)
    {
	    _stateMachine.OnAnimEvent(animName);
    }
}
