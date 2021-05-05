using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
	public int count = 10;
	public GameObject prefab;

	private void Start()
	{
		for (int i = 0; i < count; i++)
		{
			var instance = Instantiate(prefab) as GameObject;
			instance.transform.position = GetRandomPosition();
			instance.transform.localScale = GetRandomScale();
		}
	}

	private Vector3 GetRandomScale()
	{
		float scale = Random.Range(1.2f, 3f);
		return new Vector3(scale, scale, scale);
	}

	private Vector3 GetRandomPosition()
	{
		return new Vector3(
			Random.Range(-40f, 40f),
			Random.Range(-40f, 40f),
			Random.Range(-40f, 40f));
	}
}
