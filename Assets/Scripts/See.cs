using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class See : MonoBehaviour
{

    public Text New; // Moj tex
    public GameObject Parent; // Objekt ktory sa zvecsuje
    public int Scale; // o kolko sa zvecsuje kazde degrade, Grow
    public int a = 0; // Kolko znakov obsahuje text
    public int i = 0; // kolko textu je zobrazeneho
    public float Number; // Celkove zvecsenie
    public bool SmallGroup = false; // ci to je Small group
    public int MyIndex = 0; // nastavenie indexu pre objekt GGroup
    public GameObject GGroup; // Obejekt GGroup

    private int Time1 = 0;
    private bool Growed = false;
    private bool Degraded = false;


    void Start()
    {
        Number = Parent.GetComponent<LayoutElement>().preferredHeight;
         if(GGroup == false) a = New.text.Length;
    }
    void Update()
    {
        if (Time1 == 1)
        {
            i = New.cachedTextGenerator.characterCount - 1;
            if (Degraded == false && Growed == false) Grow();
            if (Degraded == false && Growed == true) Degrade();
            if (Degraded == true && Growed == true && SmallGroup == true)
            {
                GGroup.GetComponent<LayoutElement>().preferredHeight = GGroup.GetComponent<LayoutElement>().preferredHeight + this.GetComponent<LayoutElement>().preferredHeight;
                transform.SetParent(GGroup.transform);
                transform.SetSiblingIndex(MyIndex);
                i = New.cachedTextGenerator.characterCount - 1;
                a = New.text.Length;
                for (int i = 0; i < 3; i++)
                {
                    i = New.cachedTextGenerator.characterCount - 1;
                    if (i != a) Parent.GetComponent<LayoutElement>().preferredHeight = Parent.GetComponent<LayoutElement>().preferredHeight + Scale;

                }
                if(i < 40) New.resizeTextForBestFit = true;
            }
        }
        Time1++;
    }
    void Grow()
    {
        if (i != a)
        {
            Parent.GetComponent<LayoutElement>().preferredHeight = Parent.GetComponent<LayoutElement>().preferredHeight + Scale;
            Time1 = 0;
        }
        if (i == a)
        {
            Parent.GetComponent<LayoutElement>().preferredHeight = Parent.GetComponent<LayoutElement>().preferredHeight + Scale;
            Growed = true;
            Time1 = 0;
        }
    }

    void Degrade()
    {
        if (GGroup == null)
        {
            if (i == a)
            {
                Parent.GetComponent<LayoutElement>().preferredHeight = Parent.GetComponent<LayoutElement>().preferredHeight - Scale;
                Time1 = 0;
            }
            if (i != a)
            {
                Parent.GetComponent<LayoutElement>().preferredHeight = Parent.GetComponent<LayoutElement>().preferredHeight + Scale;
                Degraded = true;
            }
        }
        if (i == a && GGroup != null)
        {
            Parent.GetComponent<LayoutElement>().preferredHeight = Parent.GetComponent<LayoutElement>().preferredHeight - Scale;
            i = New.cachedTextGenerator.characterCount - 1;
            if (i > 100)
            {
                Parent.GetComponent<LayoutElement>().preferredHeight = Parent.GetComponent<LayoutElement>().preferredHeight + Scale;
            }
            i = New.cachedTextGenerator.characterCount - 1;
            for (int i = 0; i < 3; i++)
            {
                i = New.cachedTextGenerator.characterCount - 1;
                if (i != a) Parent.GetComponent<LayoutElement>().preferredHeight = Parent.GetComponent<LayoutElement>().preferredHeight + Scale;

            }
            
            Degraded = true;
            Time1 = 1;
        }
    } 
	

}
