using lesson43.Models;

namespace lesson43.Repositories
{
    public interface IQuestionsRepository
    {
        public List<Question> GetAllQuestions();
        public Question AddQuestion(Question question);
        public Question DeleteQuestion(int id);

    }
}
