using UnityEngine;

public class PlayerMove2D : MonoBehaviour
{
	[SerializeField] private float speed = 10f;
	[SerializeField] private bool isGrounded = true;
	[SerializeField] private Rigidbody rb;
	[SerializeField] float jumpForce = 50f;
	// Update is called once per frame
	void Update()
	{
		Move();
	}

	public void Move()
	{
		transform.position += transform.right * Time.deltaTime * speed * Input.GetAxis("Horizontal");
		
		if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			isGrounded = false;
			rb.AddForce(Vector3.up * jumpForce);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Floor"))
		{
			isGrounded = true;
		}
	}
}