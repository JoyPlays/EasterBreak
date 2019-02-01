using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{

	public GameObject loseScreen;


	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Ball"))
		{
			StartCoroutine("RestartScene");
		}
	}

	IEnumerator RestartScene()
	{
		loseScreen.SetActive(true);
		yield return new WaitForSeconds(3f);
		Scene activeScene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(activeScene.name);
		loseScreen.SetActive(false);

	}
}
