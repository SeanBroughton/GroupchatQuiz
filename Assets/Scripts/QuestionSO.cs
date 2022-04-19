using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]

public class QuestionSO : ScriptableObject
{
 
[TextArea(2,6)]
[SerializeField] string question = "Enter New Question";
[SerializeField] string[] answers = new string[4];
[SerializeField] int AnswerIndex;

public string GetQuestion()
{
    return question;
}

public string Answer(int index)
{
    return answers[index];
}

public int GetCorrectAnswerIndex()
{
    return AnswerIndex;
}

}
