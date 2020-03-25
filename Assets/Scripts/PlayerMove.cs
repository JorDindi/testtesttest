using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	[SerializeField] private float speed = 10f;

	void Update()
	{
		transform.position += transform.forward * Time.deltaTime * speed * Input.GetAxis("Vertical");
	}
}