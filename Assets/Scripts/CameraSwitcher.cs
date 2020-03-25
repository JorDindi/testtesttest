using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
	[SerializeField] private bool is3D = true;
	public GameObject world3D;
	public GameObject world2D;
	public PlayerMove player3D;
	public PlayerMove2D player2D;

	private void Update()
	{
		camSwitch();
	}

	public void camSwitch()
	{
		if(Input.GetKey(KeyCode.Q))
		{
			is3D = false;
			world2D.SetActive(true);
			world3D.SetActive(false);
			player3D.enabled = false;
			player2D.enabled = true;
		}
		else
		{
			is3D = true;
			world2D.SetActive(false);
			world3D.SetActive(true);
			player3D.enabled = true;
			player2D.enabled = false;
		}
	}
}
