using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class Block : MonoBehaviour
{
	public Sprite[] blockLevelSprite;
	public ParticleSystem destructionParticle;
	public Transform particlePosition;
	[SerializeField] int blockLevel;

	public GameObject[] bonuses;

	private void Start()
	{
		Debug.Log(blockLevelSprite.Length);
		blockLevel = blockLevelSprite.Length;
		gameObject.GetComponent<SpriteRenderer>().sprite = blockLevelSprite[blockLevel-1];
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		// Reduce block level by 1 every time it gets hit
		blockLevel--;
		Instantiate(destructionParticle, particlePosition.position, transform.rotation);
		if (blockLevel <= 0)
		{
			Destroy(gameObject, 0f);
			return;
		}
		gameObject.GetComponent<SpriteRenderer>().sprite = blockLevelSprite[blockLevel - 1];
	}

	private void CheckForBonuses()
	{

	}
}
