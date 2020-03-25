using UnityEngine;

public class GameManager : MonoBehaviour
{

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}
}
