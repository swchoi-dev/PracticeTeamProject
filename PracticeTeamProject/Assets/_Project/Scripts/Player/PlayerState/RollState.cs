using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollState : StateBase<PlayerContext>
{
	public RollState(PlayerContext context, StateMachine<PlayerContext> stateMachine) : base(context, stateMachine){}

	private const float ROLL_ANIMATION_TIME = 0.5f;
	private float _elapsedTime;

	public void Enter()
	{
		// 구르기 애니메이션 시작
		// 플레이어 레이어 마스크 무적으로 변경
		_elapsedTime = 0;
	}

	public void Tick()
	{
		_elapsedTime += Time.deltaTime;
		if (_elapsedTime > ROLL_ANIMATION_TIME)
		{
			sm.ChangeState(StateType.Walk);
		}
	}

	public void Exit()
	{
		// 플레이어 레이어 마스크 노말로 변경
	}
}
