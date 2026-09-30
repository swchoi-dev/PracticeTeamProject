using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollState : StateBase<PlayerContext>
{
	public RollState(PlayerContext context) : base(context){}

	public void Enter()
	{
		// 구르기 애니메이션 시작
		// 플레이어 레이어 마스크 무적으로 변경

		// 코루틴으로 애니메이션 끝날 때 호출되는거 선선
	}

	Coroutine EndRolling()
	{
		yield return WaitForSeconds("구르기시간");
		StateMachine.ChangeState(StateType.Walk);
	}

	public void Exit()
	{
		// 플레이어 레이어 마스크 노말로 변경
	}
}
