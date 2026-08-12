using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]private RectTransform _optionsPanel;
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
}
