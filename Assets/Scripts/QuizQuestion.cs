using UnityEngine;

[System.Serializable]
public class QuizQuestion
{
    [Header("Konten Soal")]
    public string questionText;

    [Tooltip("Isi jika soal punya gambar (rumah adat)")]
    public Sprite questionImage;

    [Tooltip("Centang jika soal menggunakan gambar")]
    public bool useImage;

    [Header("Jawaban Benar")]
    public string correctAnswer;
}
