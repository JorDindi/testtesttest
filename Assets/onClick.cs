using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class onClick : MonoBehaviour
{
	[SerializeField] GameObject canvas;

	public void StarGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void resumeGame()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void onPressOK()
	{
		canvas.SetActive(false);
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void onQuitPress()
	{
		Application.Quit();
	}
}
