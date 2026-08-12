using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]private RectTransform _optionsPanel;
    [SerializeField] private RectTransform _textBox;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowOptionsPanel(bool isActive)
    {
        _optionsPanel.gameObject.SetActive(isActive);
    }

    public void ShowTextBox(bool isActive)
    {
        _textBox.gameObject.SetActive(isActive);
    }      
}
