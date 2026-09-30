using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPatrolState : StateBase<MonsterContext>
{
	public MonsterPatrolState(MonsterContext context, StateMachine<MonsterContext> stateMachine) : base(context, stateMachine){}

	public void Tick()
	{
		// 플레이어가 OnTriggerEnter에 걸렸다면
		if (ctx.HasTarget)
		{
			machine.ChangeState(StateType.Trace);
		}
	}
}
