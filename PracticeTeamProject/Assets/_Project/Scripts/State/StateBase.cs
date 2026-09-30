using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateBase<T> where T : Context
{
	protected T ctx;
	protected StateMachine<T> sm;

	public StateBase() {}

	public StateBase(T context, StateMachine<T> stateMachine)
	{
		ctx = context;
		sm = stateMachine;
	}

	public virtual void Enter(){}
	public virtual void Tick(){}
	public virtual void FixedTick(){}
	public virtual void Exit(){}

	public virtual void OnAnimEvent(string animName){}
}
