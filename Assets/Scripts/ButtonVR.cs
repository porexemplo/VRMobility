using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    GameObject presser;
    AudioSource sound;
    bool isPressed;
    public bool IsClickable = false;

    public ButtonsManager buttonsManager;

    public Material clickedMaterial;
    public Renderer clickedRenderer;

    public bool VerifyClickable()
    {
        return clickedRenderer.material.name.Contains("Emmisive");
    }

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;
        Debug.Log("started");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ontrigger enter" + name);
        if (other.gameObject.CompareTag("Controller") && VerifyClickable() )
        {
            buttonsManager.ButtonClicked(this);
            sound.Play();
        }
    }

    public void TurnOffLight() {
        // Turn off the light
        Debug.Log("Turn off the light");
        //clickedRenderer.material = clickedMaterial;
    }

}
