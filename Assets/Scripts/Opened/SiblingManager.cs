using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SiblingManager : MonoBehaviour {

    public string ArrayName;
    public GameObject Parent;
    public int SetTime = 0;
    public bool MUsed = false;

    public string[] Aditional;

    private int Time;
    private string[] Array;
    private MemberScript KnowScript;

    private int MyIndex;

    void Awake()
    {
        GameObject Manager = GameObject.Find("MManager");
        KnowScript = Manager.GetComponent<MemberScript>();
        Array = (string[])KnowScript.GetType().GetField(ArrayName).GetValue(KnowScript);
        bool Can = false;
        foreach(string A in Array)
        {
            if (A != ".") Can = true;
        }
        if (Can == false) GameObject.Destroy(GameObject.Find(this.name));
    }
	void Start ()
    {
        MyInde();
	}

    public void MyInde()
    {
        for (int i = 0; i != Array.Length; i++)
        {
            if (Array[i] != ".")
            {
                MyIndex = transform.GetSiblingIndex();
                GameObject New = Instantiate(Resources.Load("SmallGroup")) as GameObject;
				if (MUsed == true) New.GetComponent<LayoutElement>().preferredHeight = 80;
                New.GetComponent<See>().SmallGroup = true;
                New.GetComponent<See>().MyIndex = i + 1;
                New.GetComponent<See>().GGroup = this.gameObject;
                New.transform.SetParent(Parent.transform);
                New.transform.SetSiblingIndex(MyIndex + i);
				New.GetComponentInChildren<Text>().text = "•" + Array[i];
                New.GetComponent<See>().a = Array[i].Length + 1;
                New.GetComponent<See>().enabled = true;
            }
        }
    }

}