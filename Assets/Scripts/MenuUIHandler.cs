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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);

        // kada pokreneš igru zapiši ime igrača u varijablu playerName
        if (playerNameText.text == "Enter your name...")
        {
            MenuManager.Instance.playerName = "Player";
        }
        else
        {
            MenuManager.Instance.playerName = playerNameText.text;
        }
        
    }
}
