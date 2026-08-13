using System.Collections.Generic;   
using UnityEngine;
using TMPro;

[System.Serializable]
public struct DialogueLine
{
    public string charName;   
    public string chatText;   
}

public class TextController : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI chatTextTMP;
    [SerializeField] private TextMeshProUGUI charNameTMP;
    [SerializeField] private List<DialogueLine> dialogo;
    private int indiceAtual = 0;

    private void MostrarFalaAtual()
    {
        DialogueLine linha = dialogo[indiceAtual];   
        chatTextTMP.text = linha.chatText;
        charNameTMP.text = linha.charName;
    }

    
    public void ProximaFala()
    {
        indiceAtual++;

        
        if (indiceAtual >= dialogo.Count)
        {
            indiceAtual = dialogo.Count - 1;
            return;
        }

        MostrarFalaAtual();
    }

    
    public void IrParaFala(int indice)
    {
        
        if (indice < 0 || indice >= dialogo.Count)
        {
            Debug.LogWarning("Índice de fala inválido: " + indice);
            return;
        }

        indiceAtual = indice;
        MostrarFalaAtual();
    }
}