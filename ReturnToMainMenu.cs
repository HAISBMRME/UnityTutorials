//Script by HAISBMRME and part of Unity Tutorial Series youtube.com/user/HAISBMRME
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToMainMenu : MonoBehaviour {
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.LoadLevel("CharacterSelect");
        }
	}
}
