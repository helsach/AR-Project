using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    [Header("Data Soal")]
    public List<QuizQuestion> allQuestions;

    [Header("UI")]
    public TMP_Text questionText;
    public Image questionImage;
    public TMP_Text scoreText;
    public Button[] answerButtons;

    private List<QuizQuestion> selectedQuestions;
    private int currentIndex = 0;
    private int score = 0;

    private string[] answers = {
        "Sumatra",
        "Jawa",
        "Kalimantan",
        "Sulawesi",
        "Papua"
    };

    void Start()
    {
        StartQuiz();
    }

    void StartQuiz()
    {
        score = 0;
        currentIndex = 0;
        scoreText.text = "Score: 0";

        // Acak & ambil 5 soal
        selectedQuestions = new List<QuizQuestion>();
        List<QuizQuestion> temp = new List<QuizQuestion>(allQuestions);

        int total = Mathf.Min(5, temp.Count);

        for (int i = 0; i < total; i++)
        {
            int rand = Random.Range(0, temp.Count);
            selectedQuestions.Add(temp[rand]);
            temp.RemoveAt(rand);
        }

        ShowQuestion();
    }

    void ShowQuestion()
    {
        QuizQuestion q = selectedQuestions[currentIndex];

        // Set pertanyaan
        questionText.text = q.questionText;

        // 🔥 FIX UTAMA: Image hanya aktif jika dipakai
        if (q.useImage && q.questionImage != null)
        {
            questionImage.gameObject.SetActive(true);
            questionImage.sprite = q.questionImage;
            questionImage.color = Color.white;
        }
        else
        {
            questionImage.gameObject.SetActive(false);
        }

        // Set tombol jawaban
        for (int i = 0; i < answerButtons.Length; i++)
        {
            int index = i;

            TMP_Text btnText = answerButtons[i].GetComponentInChildren<TMP_Text>();
            if (btnText != null)
                btnText.text = answers[i];

            answerButtons[i].onClick.RemoveAllListeners();
            answerButtons[i].onClick.AddListener(() => CheckAnswer(answers[index]));
        }
    }

    void CheckAnswer(string answer)
    {
        if (answer == selectedQuestions[currentIndex].correctAnswer)
        {
            score += 20;
            scoreText.text = "Score: " + score;
        }

        currentIndex++;

        if (currentIndex < selectedQuestions.Count)
        {
            ShowQuestion();
        }
        else
        {
            EndQuiz();
        }
    }

    void EndQuiz()
    {
        questionText.text = "Quiz Selesai!\nScore: " + score;

        questionImage.gameObject.SetActive(false);

        foreach (Button btn in answerButtons)
        {
            btn.gameObject.SetActive(false);
        }
    }
}
