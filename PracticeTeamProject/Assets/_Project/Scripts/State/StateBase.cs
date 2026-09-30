using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateBase<T> where T : Context
{
	protected T _context;

	public StateBase() {}

	public StateBase(T context)
	{
		_context = context;
	}

	public virtual void Enter(){}
	public virtual void Tick(){}
	public virtual void FixedTick(){}
	public virtual void Exit(){}


	// public virtual void OnAnimEvent(string animName){}
}
