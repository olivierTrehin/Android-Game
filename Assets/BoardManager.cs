using System.Collections;
using UnityEngine;

public class BoardManager : MonoBehaviour {

	private const float TILE_SIZE = 1.0f;
	private const float TILE_OFFST = 0.5f;

	private int selectionX = -1;
	private int selection = -1;

	// Update is called once per frame
	void Update() {
		DrawChessboard ();
	}

	private void DrawChessboard() {
		Vector3 widthLine = Vector3.right * 10;
		Vector3 heigthLine = Vector3.forward * 15;

		for (int i = 0; i <= 10; i++) {
			Vector3 start = Vector3.forward * i;
			Debug.DrawLine (start, start + widthLine);
			for(int j = 0; j <= 15; j++) {
				start = Vector3.right * j;
				Debug.DrawLine (start, start + heigthLine);
			}
		}
	}
}
