using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : StateBase<PlayerContext>
{
	public AttackState(PlayerContext context, StateMachine<PlayerContext> stateMachine) : base(context, stateMachine){}

	public void Tick()
	{
	}
}
