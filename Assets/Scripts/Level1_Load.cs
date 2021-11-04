using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Level1_Load : MonoBehaviour
{
    //public RectTransform loadingScreen;
    // Start is called before the first frame update
    void Start()
    {
        //loadingScreen.sizeDelta = new Vector2(Screen.width, Screen.height);
    }

    // Update is called once per frame
    void Update()
    {
       // SceneManager.LoadScene("1");
    }

    public void LoadFirstLevel()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadSceneAsync(1);
    }
   /* public void StartButtonPressed()
    {
        Invoke("LoadFirstLevel", 1.0f);
    }*/
}
