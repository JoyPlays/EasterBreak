using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	[SerializeField] PlayerController player1;
	[SerializeField] float xPush = 10f;
	[SerializeField] float yPush = 10f;
	[SerializeField] bool hasLaunched = false;

	Vector2 paddleToBallVector;

    // Start is called before the first frame update
    void Start()
    {
		paddleToBallVector = transform.position - player1.transform.position;
    }

    // Update is called once per frame
    void Update()
	{
		if (!hasLaunched)
		{
			LockBallToPedal();
			LaunchOnMouseClick();
		}
	}

	private void LaunchOnMouseClick()
	{
		if (Input.GetMouseButtonDown(0))
		{
			transform.GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
			hasLaunched = true;
		}
	}

	private void LockBallToPedal()
	{
		Vector2 playerPos = new Vector2(player1.transform.position.x, player1.transform.position.y);
		transform.position = paddleToBallVector + playerPos;
	}
}
