using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStat : MonoBehaviour
{
	[SerializeField] private float _attackRange;
	[SerializeField] private float _moveSpeed;

	public float AttackRange => _attackRange;
	public float MoveSpeed => _moveSpeed;
}
