using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : StateBase<PlayerContext>
{
	public WalkState(PlayerContext context) : base(context){}

	public void Tick()
	{
		var _input = _context.input;

		if (_input.SpacePressed)
		{
			StateMachine.ChangeState(StateType.Roll);
		}

		if (_input.Alpah1Pressed)
		{
			StateMachine.ChangeState(StateType.Attack);
		}
	}

	// FixedUpdate()
	public void FixedTick()
	{
		// 컨텍스트에 있는 사용자 입력값
		var _input = _context.input;
		var rb = _context.rigidbody;

		Vector3 movement = new Vector3(_input.MoveAxis.x, 0, _input.MoveAxis.z);
		rb.velocity = movement * 5f;
	}

	public void Exit()
	{

		Debug.Log("Exit");
	}
}
