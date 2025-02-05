using UnityEngine;

public class RotateY : MonoBehaviour
{
	// Rotation speed in degrees per second
	public float rotationSpeed = 90f;

	void Update()
	{
		// Rotate the object around the y-axis
		transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
	}
}