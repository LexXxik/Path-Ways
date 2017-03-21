using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marked : MonoBehaviour
{
    private SearchSc Main;

    void Start()
    {
        Main = GameObject.Find("MainScript").GetComponent<SearchSc>();
    }

    public void Mark(int SNumber)
    {
        bool On = this.gameObject.GetComponent<Toggle>().isOn;
        char Letter = this.gameObject.name[0];
        if (On == true)
        {
            Main.SearchProp[SNumber] = Main.SearchProp[SNumber] + Letter;
            if (Main.SearchProp[SNumber].Length == 1) Main.ImpNumber++;
        }
        if (On == false)
        {
            string New = "";
            for (int v = 0; v != Main.SearchProp[SNumber].Length; v++)
            {
                if (Letter != Main.SearchProp[SNumber][v]) New = New + Main.SearchProp[SNumber][v];
            }
            Main.SearchProp[SNumber] = New;
            if (Main.SearchProp[SNumber] == "") Main.ImpNumber--;
        }
    }
}
