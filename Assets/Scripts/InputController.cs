using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
	public static bool jump;
	public static bool left;
	public static bool right;
	public static bool escape;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		jump = Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space);
		left = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
		right = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
		escape = Input.GetKeyDown(KeyCode.Escape);
	}
}
