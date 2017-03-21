using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Scene : MonoBehaviour {

	private bool clicked = false;

    public void Reacting(string Scene)
    {
		if (clicked == false) 
		{
			clicked = true;
			SceneManager.LoadScene (Scene);
		}
    }
}
