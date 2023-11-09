using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    // Referência ao controle deslizante de volume no Unity UI
    public Slider volumeSlider;

    // Referência à música de fundo que será controlada pelo script
    public AudioSource backgroundMusic;

    // Função chamada no início para configurar o listener de mudança de valor do controle deslizante
    private void Start()
    {
        // Adiciona um listener para detectar mudanças no valor do controle deslizante
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    // Função chamada quando há uma mudança no valor do controle deslizante de volume
    private void ChangeVolume(float volume)
    {
        // Ajusta o volume da música de fundo de acordo com o valor do controle deslizante
        backgroundMusic.volume = volume;
    }
}
