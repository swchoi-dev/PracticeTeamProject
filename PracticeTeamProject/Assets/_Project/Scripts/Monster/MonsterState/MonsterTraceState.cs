using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTraceState : StateBase<MonsterContext>
{
	public MonsterTraceState(MonsterContext context, StateMachine<MonsterContext> stateMachine) : base(context, stateMachine){}

	public void Tick()
	{
		if (!ctx.HasTarget)
		{
			machine.ChangeState(StateType.Patrol);
			return;
		}

		float diff = Vector3.Distance(ctx.transform.position, ctx.Target.position);

		if (diff < ctx.stat.AttackRange)
		{
			machine.ChangeState(StateType.Attack);
			return;
		}

		// 몬스터 추격처리, 플레이어 Transform 은 ctx.ctx.Target
		ctx.transform.LookAt(ctx.Target);
		ctx.transform.position = Vector3.MoveTowards(
			ctx.transform.position,
			ctx.Target.position,
			ctx.stat.MoveSpeed * Time.deltaTime
		);
	}

	public void FixedTick()
	{
	}

}
