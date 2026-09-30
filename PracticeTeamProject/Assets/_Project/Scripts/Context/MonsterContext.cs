using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterContext : Context
{
	public Transform Target { get; set; }
	public bool HasTarget => Target != null;

	public MonsterStat stat;
}
