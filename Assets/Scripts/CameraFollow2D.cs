using UnityEngine;

public class CameraFollow2D : MonoBehaviour
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

		Vector3 targetPosition = new Vector3(target.transform.position.x, target.transform.position.y + 2, transform.position.z);
		transform.position = Vector3.Lerp(transform.position, targetPosition, speed);

	}
}