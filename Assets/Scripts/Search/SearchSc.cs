using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SearchSc : MonoBehaviour {

    public string[] SearchProp; // 0 title 1 autor 2 number of part 3 duration 4 TGroup 5 Enviro 6 Goals
    public string[] MethodNames;
    public string[] Authors;

    public string[] TGroup;
    public string[] Enviro;
    public string[] Goals;

    public int[] MinNumberofParticipants;
    public int[] MaxNumberofParticipans;

    public int[] DurationLimits;
	public int[] DurationMins;

    public string[] Important;
    public int ImpNumber = 0;
    public bool[] WhoSearch;

    static SearchSc Instance;

    private int DestroyCount = 0;
    void Awake()
    {
        if (Instance != null)
                GameObject.Destroy(this.gameObject);
            else
            {
                DontDestroyOnLoad(transform.gameObject);
                Instance = this;
            }
        
    }
	
	public void ActuallySearch ()
    {
        int i = 0;
	    foreach(string S in SearchProp)
        {
            int a = 0;
            if (i == 0 && SearchProp[0] != "")
            {
                foreach (string M in MethodNames)
                {
					if (M != "")
					{
						if (S[0] == M[0]) 
						{
							Important [a] = Important [a] + "y";
						}
					}
                    a++;
                }
            }
            if (i == 1 && SearchProp[1] != "")
            {
				a = 0;
                foreach (string M in Authors)
                {
					if (M != "") 
					{
						if (S [0] == M [0]) 
						{
							Important [a] = Important [a] + "y";
						}
					}
                    a++;
                }
            }

			if (i == 2 && SearchProp[2] != "" && SearchProp[2] != "0")
            {
				int[] Yes = new int[100];
                a = 0;
                int g;
                int.TryParse(S, out g);
                foreach (int M in MinNumberofParticipants)
                {
                    if (g >= M)
                    {
                        Yes[a] = 1;
                    }
                    a++;
                }
                a = 0;
                foreach (int M in MaxNumberofParticipans)
                {
                    if (g <= M)
                    {
                        Yes[a]++;
                    }
                    a++;
                }
                a = 0;
                foreach (int M in Yes)
                {
                    if (M == 2)
                    {
                        Important[a] = Important[a] + "y";
                    }
                    a++;
                }
            }
			if (i == 3 && SearchProp[3] != "" && SearchProp[3] != "0")
            {
				int[] Yes = new int[100];
				a = 0;
				int g;
				int.TryParse(S, out g);
				foreach (int M in DurationMins)
				{
					if (g >= M)
					{
						Yes[a] = 1;
					}
					a++;
				}
				a = 0;
				foreach (int M in DurationLimits)
				{
					if (g <= M)
					{
						Yes[a]++;
					}
					a++;
				}
				a = 0;
				foreach (int M in Yes)
				{
					if (M == 2 && SearchProp[i] != "")
					{
						Important[a] = Important[a] + "y";
					}
					a++;
				}
            }
            if (i == 4) MarkSearch(4, TGroup);
            if (i == 5) MarkSearch(5, Enviro);
            if (i == 6) MarkSearch(6, Goals);
            i++;
        }
        SceneManager.LoadScene("Menu Basic");

	}
    void MarkSearch(int Number, string[] Array)
    {
		int[] Good = new int[100];
        int a = 0;
		if (SearchProp [Number] != "") 
		{
			foreach (string A in Array) 
			{
				if (A != "" && a < 100) 
				{
					for (int o = 0; o < SearchProp [Number].Length; o++) 
					{
						for (int x = 0; x < A.Length; x++) 
						{
							if (SearchProp [Number] [o] == A [x]) 
							{
								Good [a]++;
								if(SearchProp[Number].Length == Good[a]) Important[a] = Important[a] + "y";
							}
						}
					}
					/*if (Good [a] != "") 
					{
						if (SearchProp [Number].Length == Good [a].Length) 
						Important[a] = Important[a] + "y";
						//Debug.Log ("kdf");
					}*/
				}
				a++;
			}
		}
    }

    void OnLevelWasLoaded()
    {
        DestroyCount++;
        if (DestroyCount > 1) GameObject.Destroy(this.gameObject);
        if (SceneManager.GetActiveScene().name == "Menu Basic")
        {
            GameObject Arrays = GameObject.Find("MenuManager");
            RegulateDisplay ArraysS = Arrays.GetComponent<RegulateDisplay>();
            int i = 0;
            foreach (string I in Important)
            {
                if(I.Length != ImpNumber)
                {
                    Destroy(GameObject.Find("Member" + i));
                }
                i++;
            }
            Serch();
        }
    }

    public void Serch()
    {
        GameObject.Destroy(gameObject);
    }
}
