using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    NewControls inputs;
    public Button primaryButton;
    void Awake()
    {       
        inputs.Player.StartOption.performed += ctx => primaryButton.Select();
    }
    void OnEnable()
    {
        inputs.Enable();
    }
    void OnDisable()
    {
        inputs.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Escena()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Salir()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
