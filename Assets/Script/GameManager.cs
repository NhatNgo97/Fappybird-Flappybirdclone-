using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{


    public GameObject button;
    public Player player;

    public Text GameoverCountDown;
    public float countdownTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
        GameoverCountDown.gameObject.SetActive(false);
        Time.timeScale = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if(player.isDead()){
            GameoverCountDown.text = "Restart in " + countdownTime.ToString("0");
            countdownTime -= Time.unscaledDeltaTime;
        }

        if(countdownTime < 0){
            Restartgame();
        }
    }

    public void Startgame(){
        button.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver(){
        Time.timeScale = 0;
        GameoverCountDown.gameObject.SetActive(true);
    }

    public void Restartgame(){
        SceneManager.LoadScene(0);
    }
}
