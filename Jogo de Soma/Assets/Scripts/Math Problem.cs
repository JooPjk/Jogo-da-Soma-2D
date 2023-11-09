using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathProblem : MonoBehaviour
{
    // Elementos de texto da interface do usuário (UI)
    public Text firstNumber;
    public Text secondNumber;
    public Text answer1;
    public Text answer2;

    // Lista para armazenar números inteiros
    public List<int> easyMathList = new List<int>();

    // Variáveis para números aleatórios e cálculos
    public int randomFirstNumber;
    public int randomSecondNumber;

    int firstNumberInProblem;
    int secondNumberInProblem;
    int answerOne;
    int answerTwo;
    int displayRandomAnswer;
    int randomAnswerPlacement;
    public int currentAnswer;
    public Text rightOrWrong_Text;

    // Chamado quando o script é executado pela primeira vez
    private void Start()
    {
        // Exibe o problema matemático inicial
        DisplayMathProblem();
    }

    // Gera e exibe um novo problema matemático
    public void DisplayMathProblem()
    {
        // Gera números aleatórios para o primeiro e segundo números
        randomFirstNumber = Random.Range(0, easyMathList.Count + 1);
        randomSecondNumber = Random.Range(0, easyMathList.Count + 1);

        // Atribui os números gerados a variáveis
        firstNumberInProblem = randomFirstNumber;
        secondNumberInProblem = randomSecondNumber;

        // Realiza uma operação simples de adição
        answerOne = firstNumberInProblem + secondNumberInProblem;

        // Escolhe aleatoriamente se deve exibir a resposta correta ou incorreta
        displayRandomAnswer = Random.Range(0, 2);
        if (displayRandomAnswer == 0)
        {
            answerTwo = answerOne + Random.Range(1, 5);
        }
        else
        {
            answerTwo = answerOne - Random.Range(1, 5);
        }

        // Exibe os números e respostas potenciais na interface do usuário
        firstNumber.text = "" + firstNumberInProblem;
        secondNumber.text = "" + secondNumberInProblem;
        randomAnswerPlacement = Random.Range(0, 2);
        if (randomAnswerPlacement == 0)
        {
            answer1.text = "" + answerOne;
            answer2.text = "" + answerTwo;
            currentAnswer = 0;
        }
        else
        {
            answer1.text = "" + answerTwo;
            answer2.text = "" + answerOne;
            currentAnswer = 1;
        }
    }

    // Chamado quando o primeiro botão é pressionado
    public void ButtonAnswer1()
    {
        // Verifica se a resposta selecionada está correta e exibe feedback
        if (currentAnswer == 0)
        {
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.green;
            rightOrWrong_Text.text = ("Correto!");
            Invoke("TurnOffText", 1);
        }
        else
        {
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.red;
            rightOrWrong_Text.text = ("Tente novamente!");
            Invoke("TurnOffText", 1);
        }
    }

    // Chamado quando o segundo botão é pressionado
    public void ButtonAnswer2()
    {
        // Verifica se a resposta selecionada está correta e exibe feedback
        if (currentAnswer == 1)
        {
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.green;
            rightOrWrong_Text.text = ("Correto!");
            Invoke("TurnOffText", 1);
        }
        else
        {
            rightOrWrong_Text.enabled = true;
            rightOrWrong_Text.color = Color.red;
            rightOrWrong_Text.text = ("Tente novamente!");
            Invoke("TurnOffText", 1);
        }
    }

    // Desativa o texto de feedback e exibe um novo problema matemático
    public void TurnOffText()
    {
        if (rightOrWrong_Text != null)
        {
            rightOrWrong_Text.enabled = false;
            DisplayMathProblem();
        }
    }
}
