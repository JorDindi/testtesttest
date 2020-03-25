using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	[SerializeField] private GameObject target;
	[SerializeField] private float speed = 1;

	//private Vector3 offset;

	private void Start()
	{
		//offset = target.transform.position - transform.position;
	}

	private void LateUpdate()
	{
		//Vector3 targetPosition = target.transform.position - offset;

		transform.position = Vector3.Lerp(transform.position, target.transform.position, speed);

	}
}