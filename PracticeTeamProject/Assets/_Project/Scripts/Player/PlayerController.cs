using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody _rigidbody;
	private Transform _transform;
	private Animator _animator;
	private Camera _camera;

	private StateMachine<PlayerContext> _machine;
	private PlayerContext _ctx;
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
		_machine.ChangeState(StateType.Walk);
	}

    private void Update()
    {
		_input.Read();

		_machine.Tick();
    }

    private void FixedUpdate()
    {
	    _machine.FixedTick();
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
	    _ctx.camera = _camera;
	    _ctx.rigidbody = _rigidbody;
	    _ctx.transform = _transform;
	    _ctx.input = _input;
    }

    private void InitStateMachine()
    {
	    _machine = new StateMachine<PlayerContext>();

	    _machine.AddState(StateType.Attack, new AttackState(_ctx, _machine));
	    _machine.AddState(StateType.Walk, new WalkState(_ctx, _machine));
	    _machine.AddState(StateType.Roll, new RollState(_ctx, _machine));
    }

    private void OnAnimEvent(string animName)
    {
	    _machine.OnAnimEvent(animName);
    }
}
