using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
	public float destroyTimer;

	private void Start()
	{
		StartCoroutine("DestroyAfter", destroyTimer);
	}

	IEnumerator DestroyAfter(float time)
	{
		yield return new WaitForSeconds(time);
		Destroy(gameObject, 0f);
	}
}
