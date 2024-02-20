using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    public GameState gameState;
    public Slider sliderHealth;
    public Slider sliderEarth;
    public TMP_Text score;
    public float UIScore;
    public GameObject Earth;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Health earthHealth=Earth.GetComponent<Health>();
        Health playerHealth=Player.GetComponent<Health>();


        sliderEarth.value=earthHealth.currentHealth;
        sliderEarth.maxValue=earthHealth.maxHealth;
        sliderHealth.value=playerHealth.currentHealth;
        sliderHealth.maxValue=playerHealth.maxHealth;



        UIScore=gameState.Score;

        score.text="Score: "+UIScore;



    }
    
}
