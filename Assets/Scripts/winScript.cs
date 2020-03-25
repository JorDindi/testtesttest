using UnityEngine;
using UnityEngine.SceneManagement;

public class winScript : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			Cursor.lockState = CursorLockMode.None;
		}
	}
}
