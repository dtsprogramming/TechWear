using System;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class HamburgerMenu : MonoBehaviour
{
    [SerializeField] private GameObject[] menuButtons;
    [SerializeField] private TextMeshProUGUI buttonText;

    private bool isOpen = false;

    public void setHamburgerStatus()
    {
        isOpen = !isOpen;
        SetBurgerText();
        HideShowButtons();
    }

    private void SetBurgerText()
    {
        buttonText.text = isOpen ? "X" : "|||";
    }

    public void HideShowButtons()
    {
        foreach (var button in menuButtons)
        {
            button.gameObject.SetActive(isOpen);
        }
    }
}
