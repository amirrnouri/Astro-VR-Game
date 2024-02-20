using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameState gameState;
    public TMP_Text score;
    public TMP_Text playButtonText;
    public AudioClip audioSourceCrash;
    // Start is called before the first frame update
    void Start()
    {
        score.enabled=false;
        if (gameState.Score>0)
        {
        score.enabled=true;
        score.text="Score: "+gameState.Score;
        playButtonText.text="Play Again";
        AudioSource.PlayClipAtPoint(audioSourceCrash,new Vector3 (0,0,0));
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }


}
