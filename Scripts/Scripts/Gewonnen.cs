using UnityEngine.SceneManagement;
using UnityEngine;

public class Gewonnen : MonoBehaviour
{
    public static bool isGewonnen;
    public GameObject Gewonnenscreen;

    private void Awake()
    {
        isGewonnen = false;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isGewonnen)
        {
            Gewonnenscreen.SetActive(true);

        }
    }
    public void replayLevel()
    {
        SceneManager.LoadScene("Level01");
    }
}


