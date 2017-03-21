using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegulateDisplay : MonoBehaviour {

    public GameObject[] Methodes;
    private Text Title;
    int i = 0;

    void LateStart()
    {
        Title = GameObject.Find("BE").GetComponent<Text>();
        if (GameObject.Find("MainScript") == null) Title.text = "FAVOURITE";
    }
    void OnLevelWasLoaded()
    {
        if (SceneManager.GetActiveScene().name == "Menu Basic")
        {
            Title = GameObject.Find("BE").GetComponent<Text>();
            if (GameObject.Find("MainScript") == null) Title.text = "FAVOURITE";
        }
    }
}
