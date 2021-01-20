using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class Button : MonoBehaviour
{
    public int ButtonIndex { get; set; }
    [SerializeField]GameManager gm;
    [SerializeField]Color defaultColor;    
    [SerializeField]Color highlightColor;
    [SerializeField]float resetDelay = .25f;
    
    

    AudioSource sound;


    void Start()
    {
        ResetButton();
    }

    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }


    public void PressButton()
    {
        Debug.Log("Click");

        sound.Play();
        GetComponent<MeshRenderer>().material.color = highlightColor;
        Invoke("ResetButton", resetDelay);
    }

    private void OnMouseDown()
    {
        gm.PlayersPick(ButtonIndex);
        PressButton();
    }

    void ResetButton()
    {
        GetComponent<MeshRenderer>().material.color = defaultColor;
    }
}
