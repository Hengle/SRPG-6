using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {
    public void OnClick() {
        SceneManager.LoadScene("GameScene");
    }
}
