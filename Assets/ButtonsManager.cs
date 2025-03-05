using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsManager : MonoBehaviour
{
    // Start is called before the first frame update

    public List<ButtonVR> buttons;
    public List<Renderer> buttonRenders;

    public Material emissiveMaterial;
    public Material defaultMaterial;

    public void ButtonClicked(ButtonVR target)
    {
        var index = buttons.IndexOf(target);
        buttonRenders[index].material = defaultMaterial;

        var randomIndex = Random.Range(0, buttons.Count);
        buttons[randomIndex].IsClickable = true;
        Debug.Log("Set cliback: " + buttons[randomIndex].IsClickable + " " + buttons[randomIndex].gameObject.name);
        buttonRenders[randomIndex].material = emissiveMaterial;
    }

    void Start()
    {
        var randomIndex = Random.Range(0, buttons.Count);
        Debug.Log("index: " + randomIndex);
        buttonRenders[randomIndex].material = emissiveMaterial;
        buttons[randomIndex].IsClickable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
