using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttackState : StateBase<MonsterContext>
{
	public MonsterAttackState(MonsterContext context, StateMachine<MonsterContext> stateMachine) : base(context, stateMachine){}
}
