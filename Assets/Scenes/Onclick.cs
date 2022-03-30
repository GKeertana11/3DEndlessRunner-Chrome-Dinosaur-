using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Onclick : MonoBehaviour
{
    public Button play;
    public Button gameplay;
    
    public Button back;


    public GameObject startpanel;
    
    public GameObject gamepanel;


    // Start is called before the first frame update
    void Start()
    {
        play.onClick.AddListener(Play);
        gameplay.onClick.AddListener(Gameplay);
       
        back.onClick.AddListener(Back);
       
    }

    public void Back()
    {
        startpanel.SetActive(true);
        gamepanel.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);



    }
    public void Gameplay()
    {
        startpanel.SetActive(false);
        gamepanel.SetActive(true);
    }
    

}

