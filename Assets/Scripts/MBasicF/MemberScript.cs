using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MemberScript : MonoBehaviour {

    public string Name;
    public string Autor;
    public string Duration; 
    public string NumberOfPart;
    public string[] Materials;
    public string[] Site;
    public string Summary;

    public string[] TargetGroup;
    public string[] Goals;
    public string[] Content;
    public string[] Description;
    public string Outcome;
    public string Availability;
    public string[] MethodUsed; // 0 - title of that project 1 - web adress 2 - e mail 3 - role of method 4 - Eastern eruropen contex

    public Text Title;
    public Text AuthorT;
    public Text Subtitle;
    public Text Index;

    public GameObject FavouriteO;
    [SerializeField]
    private int Opened = 0;
    private string ParentName = "";
    public bool Favourite = false;

    void Awake()
    {
        if (Opened > 1) GameObject.Destroy(this.gameObject);
        LoadMenu();
        if (SceneManager.GetActiveScene().name == "Menu Basic")
        {
            string Now;
            ParentName = transform.parent.name;
            GameObject P = GameObject.Find(ParentName);
            Now = PlayerPrefs.GetString(ParentName);
            if (Now == "1")
            {
                FavouriteO.GetComponent<Image>().sprite = Resources.Load<Sprite>("srdce-red");
                Favourite = true;
            }
            if (Now == "")
            {
                FavouriteO.GetComponent<Image>().sprite = Resources.Load<Sprite>("srdce-black");
                Favourite = false;
                if(GameObject.Find("MainScript") == null) P.SetActive(false);
            }
        }
    }

    void Start()
    {
    }

    void OpenedScene()
    {
        int a;
        a = 1;
        GameObject.Find("Name").GetComponent<Text>().text = Name;
        GameObject.Find("Autor").GetComponent<Text>().text = Autor;
        if(Favourite == true) GameObject.Find("Favourite").GetComponent<Image>().sprite = Resources.Load<Sprite>("srdce-red");
        GameObject.Find("Duration").GetComponent<Text>().text = Duration;
        GameObject.Find("Group").GetComponent<Text>().text = NumberOfPart;


        foreach(string S in Site)
        {
            if (a != Site.Length) GameObject.Find("Site").GetComponent<Text>().text = S + ", ";
            if (a == Site.Length) GameObject.Find("Site").GetComponent<Text>().text = S;
            a++;
        }

        a = 1;
        foreach (string Thing in Materials)
        {
            if (a != Materials.Length) GameObject.Find("Material").GetComponent<Text>().text = Thing + ", ";
            if (a == Materials.Length) GameObject.Find("Material").GetComponent<Text>().text = Thing;
            a++;
        }

        a = 0;
        foreach (string Con in Content)
        {
            if (a == 0) GameObject.Find("Content").GetComponent<Text>().text = Con;
            if (a != 0) GameObject.Find("Content").GetComponent<Text>().text = GameObject.Find("Content").GetComponent<Text>().text + "\n" + Con;
            a++;
        }

        a = 0;
        foreach (string Part in Description)
        {
            if(a == 0) GameObject.Find("Description").GetComponent<Text>().text = Part;
            if (a != 0)GameObject.Find("Description").GetComponent<Text>().text = GameObject.Find("Description").GetComponent<Text>().text + "\n" + "\n" + Part;
            a++;
        }
        GameObject.Find("Outcome").GetComponent<Text>().text = Outcome;
        if (Availability != null) GameObject.Destroy(GameObject.Find("AVA"));
        if (Availability != null) GameObject.Find("Available").GetComponent<Text>().text = Availability;
    }
    void LoadMenu()
    {
        if (SceneManager.GetActiveScene().name == "Menu Basic")
        {
            Title.text = Name;
            AuthorT.text = Autor;
            Index.text = Duration;
            Index.text = Index.text + "\n" + NumberOfPart + "\n" + Materials[0] + "..." + "\n" + Site[0] + "\n" + "\n";
            Index.text = Index.text + Summary;
        }
    }

    public void OnClick()
    {
        GameObject Manager = GameObject.FindGameObjectWithTag("Parent");
        transform.parent = Manager.transform;
        SceneManager.LoadScene("Opened");
    }

    public void OnClickFavourite()
    {
        Favourite = !Favourite;
        if (Favourite == true)
        {
            PlayerPrefs.SetString(ParentName, "1");
            FavouriteO.GetComponent<Image>().sprite = Resources.Load<Sprite>("srdce-red");
        }
        if (Favourite == false)
        {
            PlayerPrefs.SetString(ParentName, "");
            FavouriteO.GetComponent<Image>().sprite = Resources.Load<Sprite>("srdce-black");
        }
    }

    void OnLevelWasLoaded()
    {
        Opened++;
        int Variable = 0;
        if (SceneManager.GetActiveScene().name == "Menu Basic" && Opened > 1) GameObject.Destroy(this.gameObject);
        foreach(string One in MethodUsed) if (One == null) Variable++;
        if (Variable == MethodUsed.Length) GameObject.Destroy(GameObject.Find("12"));
        if (SceneManager.GetActiveScene().name == "Opened") OpenedScene();
    }
}
