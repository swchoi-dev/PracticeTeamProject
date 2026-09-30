using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine<T> where T : Context
{
	private Dictionary<StateType, StateBase<T>> _stateDict;
	private StateBase<T> _current;

	public StateMachine()
	{
		_stateDict = new Dictionary<StateType, StateBase<T>>();
	}

	public void AddState(StateType stateType, StateBase<T> state)
	{
		if (!_stateDict.ContainsKey(stateType))
		{
			_stateDict.Add(stateType, state);
		}
	}

	public void ChangeState(StateType nextState)
	{
		StateBase<T> next = _stateDict[nextState];

		_current?.Exit(); // WalkState.Exit(); //걷기 애니메이션 종료

		_current = next; // 현재 상태가 걷기에서 구르기

		_current.Enter(); // RollState.Enter();
	}

	public void OnEnter() => _current.Enter();
	public void Tick() => _current.Tick();
	public void FixedTick() => _current.FixedTick();
	public void OnExit() => _current.Exit();

	public void OnAnimEvent(string animName) => _current.OnAnimEvent(animName);
}
