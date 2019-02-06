using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	[SerializeField] float screenWidthInUnits = 16f;
	[SerializeField] float minX = 0.5f;
	[SerializeField] float maxX = 15.5f;

	// Update is called once per frame
	void Update()
    {
		float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
		Vector2 playerPos = new Vector2(Mathf.Clamp(mousePosInUnits, minX, maxX), transform.position.y);
		transform.position = playerPos;
    }
}
