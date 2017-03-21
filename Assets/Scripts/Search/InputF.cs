using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputF : MonoBehaviour {

    public GameObject Maine;
    public int Multipler = 0;
    private SearchSc MaineS;
    private int Before = 1;

    public bool Searched = false;
    public bool Duration = false;

    void Awake()
    {
        MaineS = Maine.GetComponent<SearchSc>();
    }
    public void OnEndCHInput(string SearchN)
    {
        string Form = this.GetComponent<InputField>().textComponent.text;
        int SearchNumber;
        int.TryParse(SearchN, out SearchNumber);
        if (Form == "" && Searched == true)
        {
            MaineS.SearchProp[SearchNumber] = "";
            Searched = false;
            MaineS.ImpNumber--;
        }
        if (Form != "")
        {
            MaineS.SearchProp[SearchNumber] = "";
            TextCheckLetters(0, SearchNumber, this.gameObject);
            if(Form.Length > 1) TextCheckLetters(1, SearchNumber, this.gameObject);
            if (Searched == false) MaineS.ImpNumber++;
            Searched = true;
        }
    }

    public void Dropdown(int SearchNumber)
    {
        int GDrop = GameObject.Find("Dropdowned").GetComponent<Dropdown>().value;
        int Feature;
        int.TryParse(this.GetComponent<InputField>().textComponent.text, out Feature);
        if (GDrop == 1) Feature = Feature * 60;
        if (GDrop == 2) Feature = Feature * 24 * 60;
        Before = GDrop;
        MaineS.SearchProp[SearchNumber] = Feature.ToString();
    }

    public void OnEndCHInputNumbers(string SearchN)
    {
        string Form = this.GetComponent<InputField>().textComponent.text;
        int SearchNumber;
        int.TryParse(SearchN, out SearchNumber);
        if (Form == "" && Searched == true)
        {
            MaineS.SearchProp[SearchNumber] = "";
            Searched = false;
            MaineS.ImpNumber--;
        }
        if (Form != "")
        {
            MaineS.SearchProp[SearchNumber] = "";
            for(int x = 0; x < Form.Length; x++) NumberCheck(x, SearchNumber, this.gameObject);
            if (Searched == false) MaineS.ImpNumber++;
            Searched = true;
            if (Duration == true) Dropdown(SearchNumber);
        }
    }

    public void TextCheckLetters(int CharN, int SearchNumber, GameObject Parent)
    {
        string FromText = Parent.GetComponent<InputField>().textComponent.text;
        bool Found = false;
        if (FromText.Length > CharN)
        {
            if (FromText[CharN] == 'A')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'a';
                Found = true;
            }
            if (FromText[CharN] == 'B')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'b';
                Found = true;
            }
            if (FromText[CharN] == 'C')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'c';
                Found = true;
            }
            if (FromText[CharN] == 'D')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'd';
                Found = true;
            }
            if (FromText[CharN] == 'E')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'e';
                Found = true;
            }
            if (FromText[CharN] == 'F')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'f';
                Found = true;
            }
            if (FromText[CharN] == 'G')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'g';
                Found = true;
            }
            if (FromText[CharN] == 'H')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'h';
                Found = true;
            }
            if (FromText[CharN] == 'I')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'i';
                Found = true;
            }
            if (FromText[CharN] == 'J')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'j';
                Found = true;
            }
            if (FromText[CharN] == 'K')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'k';
                Found = true;
            }
            if (FromText[CharN] == 'L')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'l';
                Found = true;
            }
            if (FromText[CharN] == 'M')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'm';
                Found = true;
            }
            if (FromText[CharN] == 'N')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'n';
            }
            if (FromText[CharN] == 'O')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'o';
                Found = true;
            }
            if (FromText[CharN] == 'P')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'p';
                Found = true;
            }
            if (FromText[CharN] == 'Q')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'q';
                Found = true;
            }
            if (FromText[CharN] == 'R')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'r';
                Found = true;
            }
            if (FromText[CharN] == 'S')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 's';
                Found = true;
            }
            if (FromText[CharN] == 'T')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 't';
                Found = true;
            }
            if (FromText[CharN] == 'U')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'u';
                Found = true;
            }
            if (FromText[CharN] == 'V')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'v';
                Found = true;
            }
            if (FromText[CharN] == 'W')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'w';
                Found = true;
            }
            if (FromText[CharN] == 'X')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'x';
                Found = true;
            }
            if (FromText[CharN] == 'Y')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'y';
                Found = true;
            }
            if (FromText[CharN] == 'Z')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 'z';
                Found = true;
            }
            if (FromText[CharN] == 'Š')
            {
                MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + 's';
                Found = true;
            }
            if (Found == false) MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + FromText[CharN];
        }
    }
    public void NumberCheck(int CharN, int SearchNumber, GameObject Parent)
    {
        string FromText = Parent.GetComponent<InputField>().textComponent.text;
        if (FromText[CharN] != '0' || FromText[CharN] != '1' || FromText[CharN] != '2' || FromText[CharN] != '3' || FromText[CharN] != '4' || FromText[CharN] != '5' || FromText[CharN] != '6' || FromText[CharN] != '7' || FromText[CharN] != '8' || FromText[CharN] != '9')
        {
            MaineS.SearchProp[SearchNumber] = MaineS.SearchProp[SearchNumber] + FromText[CharN];
        }
        else MaineS.SearchProp[SearchNumber] = "";
    }

}
