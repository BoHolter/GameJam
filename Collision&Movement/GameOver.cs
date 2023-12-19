using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameoverscreen;

    private void Awake()
    {
        isGameOver = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            gameoverscreen.SetActive(true); 

        }
    }
    public void replayLevel()
    {
        SceneManager.LoadScene("Level01");
    }
}

