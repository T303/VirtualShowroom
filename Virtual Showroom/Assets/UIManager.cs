using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    string currentlySelectedOption = "none";
    public GameObject colorOptionsPanel;
    public GameObject finishOptionsPanel;
    public GameObject tintOptionsPanel;
    public GameObject wheelOptionsPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deactivateAllOptionPanels()
    {
        colorOptionsPanel.SetActive(false);
        finishOptionsPanel.SetActive(false);
        tintOptionsPanel.SetActive(false);
        wheelOptionsPanel.SetActive(false);
    }

    public void selectColorOption()
    {
        currentlySelectedOption = "color";
        deactivateAllOptionPanels();
        colorOptionsPanel.SetActive(true);
    }

    public void selectFinishOption()
    {
        currentlySelectedOption = "finish";
        deactivateAllOptionPanels();
        finishOptionsPanel.SetActive(true);
    }

    public void selectWindowTintOption()
    {
        currentlySelectedOption = "tint";
        deactivateAllOptionPanels();
        tintOptionsPanel.SetActive(true);
    }

    public void selectWheelOption()
    {
        currentlySelectedOption = "wheels";
        deactivateAllOptionPanels();
        wheelOptionsPanel.SetActive(true);
    }
}
