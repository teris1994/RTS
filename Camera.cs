using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{
	/*
	 * The axes of X go right or left.
	 * {
	 * 	The + go right. 
	 *  The - go left.
	 * }
	 * 
	 * The axes of Y is the zoom.
	 * {
	 *  The + zoom out.
	 *  The - zoom in.
	 * }
	 * 
	 * The axes of Z is the up-down.
	 * {
	 *  The + up.
	 *  The - down.
	 * }
	 * 
	 * The below information is base on "Camera Preview".
	 * W-up
	 * S-down
	 * A-left
	 * D-right
	 * Q:Zoom in camera or mouse scroll.
	 * E:Zoom out camera or mouse scroll.
	 * Please report if you have a better system for camera.
	 */

	public int stepCameraMove = 5;
	public int stepMouseZoom = 15;


	// Use this for initialization
	void Start ()
	{
		//TODO: Need add max and min zoom value and right left down up max size of map :.
	}

	// Update is called once per frame
	void Update ()
	{
		//transform.Translate (new Vector3 (x, y,z,null?));
		//transform.Translate (new Vector3 (1, 1,1,wtf?));
		CameraMove();

	}

	void CameraMove()
	{

		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate (new Vector3 (0,1,0));
		}
		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate (new Vector3 (0,-1,0));
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate (new Vector3 (-1,0,0));
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Translate (new Vector3 (1,0,0));
		}

		//Mouse Zoom
		transform.Translate(stepMouseZoom*Vector3.forward * Input.GetAxis("Mouse ScrollWheel"));

		if(Input.GetKey(KeyCode.Q))
		{
			transform.Translate (new Vector3 (0,0,1));
		}
		if(Input.GetKey(KeyCode.E))
		{
			transform.Translate (new Vector3 (0,0,-1));
		}
	}
}

