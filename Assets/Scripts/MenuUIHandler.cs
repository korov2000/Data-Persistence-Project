using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
//[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;
    public string bestPlayerNameUI;
    public int bestPlayerScoreUI;

    // Start is called before the first frame update
    void Start()
    {
        MenuManager.Instance.Load();
        bestPlayerNameUI = MenuManager.Instance.bestPlayerName;
        bestPlayerScoreUI = MenuManager.Instance.bestPlayerScore;

        // ovdje treba još napraviti prikazivanje najboljeg playera i score-a
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);

        //Debug.Log(Application.persistentDataPath);

        // kada pokreneš igru zapiši ime igrača u varijablu playerName
        MenuManager.Instance.playerName = playerNameText.text;
    }
}
