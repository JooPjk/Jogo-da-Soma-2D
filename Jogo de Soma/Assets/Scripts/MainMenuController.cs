using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Painéis que serão manipulados no código
    public CanvasGroup OptionPanel;
    public CanvasGroup InfoPanel;

    // Função chamada quando o botão "Play" é clicado
    public void PlayGame()
    {
        // Carrega a próxima cena no índice da cena atual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Função chamada quando o botão "Option" é clicado
    public void Option()
    {
        // Torna o painel de opções visível e interativo
        OptionPanel.alpha = 1;
        OptionPanel.blocksRaycasts = true;
    }

    // Função chamada quando o botão "Info" é clicado
    public void Info()
    {
        // Torna o painel de informações visível e interativo (talvez haja um erro aqui, pois está manipulando OptionPanel em vez de InfoPanel)
        InfoPanel.alpha = 1;
        InfoPanel.blocksRaycasts = true;
    }

    // Função chamada quando o botão "Back" é clicado
    public void Back()
    {
        // Oculta o painel de opções e o torna não interativo
        OptionPanel.alpha = 0;
        OptionPanel.blocksRaycasts = false;
    }

    // Função chamada quando o botão "Quit" é clicado
    public void QuitGame()
    {
        // Encerra a aplicação (funciona apenas em builds standalone)
        Application.Quit();
    }
}
