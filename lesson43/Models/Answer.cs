namespace lesson43.Models
{
    public class Answer
    {
        public Answer()
        {
            IsCorrect = false;
        }
        public int ID { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
    }
}
