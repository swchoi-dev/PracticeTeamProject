using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
	private Rigidbody _rigidbody;
	private Transform _transform;
	private Animator _animator;
	private MonsterStat _monsterStat;

	private StateMachine<MonsterContext> _machine;
	private MonsterContext _ctx;

	private void Awake()
	{
		CacheComponents();
		BindContext();
		InitStateMachine();
	}

	private void Update()
	{
		_machine.Tick();
	}

	private void FixedUpdate()
	{
		_machine.FixedTick();
	}

	private void OnTriggerEnter(Collider other)
	{
		// 레이어 마스크 처리 필요
		if (!other.CompareTag("Player")) return;
		_ctx.Target = other.transform;
	}

	private void OnTriggerExit(Collider other)
	{
		if (_ctx.Target != null && other.transform == _ctx.Target)
		{
			_ctx.Target = null;
		}
	}

	private void CacheComponents()
	{
		_animator = GetComponent<Animator>();
		_rigidbody = GetComponent<Rigidbody>();
		_transform = GetComponent<Transform>();
		_monsterStat = GetComponent<MonsterStat>();
	}

	private void BindContext()
	{
		_ctx.rigidbody = _rigidbody;
		_ctx.transform = _transform;
		_ctx.animator = _animator;
		_ctx.stat = _monsterStat;
	}

	private void InitStateMachine()
	{
		_machine = new StateMachine<MonsterContext>();

		_machine.AddState(StateType.Attack, new MonsterAttackState(_ctx, _machine));
		_machine.AddState(StateType.Patrol, new MonsterPatrolState(_ctx, _machine));
		_machine.AddState(StateType.Trace, new MonsterTraceState(_ctx, _machine));
	}
}
