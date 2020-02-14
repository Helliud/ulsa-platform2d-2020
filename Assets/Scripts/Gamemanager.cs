﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    [SerializeField]
    Score score;

    public Score Score { get => score; }

    void Awake()
    {
        if(instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {/*
        int scene = SceneManager.GetActiveScene().buildIndex;
        //Estamos diciendo que mientras sea mayor al menu (0)
        gameObject.SetActive(scene > 0);*/

    }
}
