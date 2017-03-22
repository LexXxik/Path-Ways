using UnityEngine;
using System.Collections;

public class Dont : MonoBehaviour
{

    static Dont Instance;

    void Start()
    {
        if (Instance != null)
            GameObject.Destroy(this.gameObject);
        else
        {
            DontDestroyOnLoad(transform.gameObject);
            Instance = this;
        }
    }

}
