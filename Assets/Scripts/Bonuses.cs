using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonuses : MonoBehaviour
{
	public string bonusName;
	public SpriteRenderer bonusSprite;

	public Bonuses (string newName, SpriteRenderer newSprite)
	{
		bonusName = newName;
		bonusSprite = newSprite;
	}
}
