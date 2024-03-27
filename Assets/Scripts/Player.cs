using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    // public static Player Instance
    // {
    //     get
    //     {
    //         if (_instance == null)
    //         {
    //             _instance = FindObjectOfType<Player>();
    //             if (_instance != null)
    //             {
    //                 DontDestroyOnLoad(_instance.gameObject);
    //             }
    //         }
    //
    //         return _instance;
    //     }
    // }
    //
    // private static Player _instance;
    //
    // private void Awake()
    // {
    //     if (_instance == null)
    //     {
    //         _instance = this;
    //         DontDestroyOnLoad(gameObject);
    //         Debug.Log("Fond Singltone into Awake() if statement");
    //     }
    //     else
    //     {
    //         Debug.Log("statement ELSE");
    //         Destroy(gameObject);
    //     }
    // }

    [SerializeField] private float _health;

    private bool _isRifleInTheHands;

    private void Update()
    {
        
    }
}