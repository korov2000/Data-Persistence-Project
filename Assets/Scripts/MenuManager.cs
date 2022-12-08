using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    // varijabla za ulovit ime igrača - puni se u MenuUIHandler.cs
    public string playerName;
    
    public string bestPlayerName;
    public int bestPlayerScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    [System.Serializable] class SaveData
    {
        public string saveName;
        public int saveScore;
    }

    public void Save()
    {
        SaveData data = new SaveData();
        data.saveName = bestPlayerName;
        data.saveScore = bestPlayerScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void Load()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestPlayerName = data.saveName;
            bestPlayerScore = data.saveScore;

        }
    }
}
