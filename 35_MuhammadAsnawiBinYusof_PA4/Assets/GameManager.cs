using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        timer++;
        SceneManager.LoadScene("CubeScene", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {


        
    }
}
