using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
	public bool invertForward = false;

	void Update()
	{
		if (Camera.main != null)
		{
			Vector3 direction = Camera.main.transform.position - transform.position;
			if (invertForward)
			{
				direction = -direction;
			}
			transform.rotation = Quaternion.LookRotation(direction);
		}
	}
}
