using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour {

	public Transform target;
	public float smoothSpeed = 5.25f;
	public Vector3 cameraOffset;

	void FixedUpdate () {
		Vector3 desiredPos = target.position + cameraOffset;
		Vector3 smoothedPos = Vector3.Lerp (transform.position, desiredPos, smoothSpeed * Time.deltaTime);
		transform.position = smoothedPos;
	}
}