using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneAfterSecond : MonoBehaviour
{
    //public LoadScene ls;
    [SerializeField]private LoadScene ls;

    public float second;
    public string sceneName;
    void Start()
    {
        ls = GetComponent<LoadScene>();
        Invoke("ChangeAfterSecond", second);
    }

    public void ChangeAfterSecond()
    {
        ls.ChangeScene(sceneName);
    }
 
}
