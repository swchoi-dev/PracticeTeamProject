using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput
{
	public Vector3 MouseDelta { get; private set; }
	public Vector3 MoveAxis { get; private set; }

	public bool Alpah1Pressed { get; private set; }
	public bool Alpah2Pressed { get; private set; }
	public bool Alpah3Pressed { get; private set; }
	public bool SpacePressed { get; private set; }
	public bool MenuButtonPressed { get; private set; }

	public void Read()
	{
		// (-y, x, 0)
		MouseDelta = new Vector3(
			-(Input.GetAxis("Mouse Y")),
			Input.GetAxis("Mouse X"),
			0
		);

		// (x,MoveAxi 0 ,z)
		MoveAxis = new Vector3(
			Input.GetAxis("Horizontal"),
			0,
			Input.GetAxis("Vertical")
		);

		Alpah1Pressed = Input.GetKeyDown(KeyCode.Alpha1);
		Alpah2Pressed = Input.GetKeyDown(KeyCode.Alpha2);
		Alpah3Pressed = Input.GetKeyDown(KeyCode.Alpha3);

		MenuButtonPressed = Input.GetKeyDown(KeyCode.Escape);
		SpacePressed = Input.GetKeyDown(KeyCode.Space);
	}
}
