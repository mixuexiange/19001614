using UnityEngine;
using System.Collections;

public class managescenes : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnStartGame(string sceneName)
    {
        Application.LoadLevel("Start");
    }
    public void OnStartGame(int sceneIndex)
    {
        Application.LoadLevel(sceneIndex);
    }
}
