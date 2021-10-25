using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Canvas))]
public class Fade : MonoBehaviour
{
	[SerializeField] float target = 20.0f;
	[SerializeField] float speed = 5.0f;
	[SerializeField] float current = 10f;

	float now = 0;
	float offset = 0;

	void Update()
	{
		offset = Mathf.MoveTowards(current, target, speed * Time.deltaTime);
		now += offset;
		Debug.Log($"offset {offset}, now {now}");
	}

	// Math.Pow(2, interval)
}
