using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : StateBase<PlayerContext>
{
	public WalkState(PlayerContext context, StateMachine<PlayerContext> stateMachine) : base(context, stateMachine){}

	public void Tick()
	{
		var _input = ctx.input;

		if (_input.SpacePressed)
		{
			sm.ChangeState(StateType.Roll);
		}

		if (_input.AttackPressed)
		{
			sm.ChangeState(StateType.Attack);
		}
	}

	// FixedUpdate()
	public void FixedTick()
	{
		// 컨텍스트에 있는 사용자 입력값
		var _input = ctx.input;
		var rb = ctx.rigidbody;

		Vector3 movement = new Vector3(ctx.input.MoveAxis.x, 0, ctx.input.MoveAxis.z);
		ctx.rigidbody.velocity = movement * 5f;
	}

	public void Exit()
	{
		Debug.Log("Exit");
	}
}
