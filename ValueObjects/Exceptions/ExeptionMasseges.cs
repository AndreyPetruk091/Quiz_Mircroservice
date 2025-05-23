namespace ValueObjects.Exceptions
{
    public static class ExceptionMessages
    {
        // ����� ���������
        public const string NullValue = "{0} �� ����� ���� null";
        public const string EmptyValue = "{0} �� ����� ���� ������";

        // ��������� ��� Username
        public const string UsernameTooShort = "Username ������ ��������� ������� {0} ��������";
        public const string UsernameTooLong = "Username ������ ��������� �������� {0} ��������";
        public const string UsernameInvalidChars = "Username ����� ��������� ������ �����, �����, '-', '_' � '.'";

        public const string EmptyAnswer = "Answer cannot be empty";
        public const string InvalidAnswerIndex = "Answer index must be between 0 and {0}";
        public const string EmptyQuestionText = "Question text cannot be empty";
        public const string QuestionTextTooLong = "Question text exceeds maximum length of {0} characters";
        public const string EmptyQuizTitle = "Quiz title cannot be empty";
        public const string QuizTitleTooLong = "Quiz title exceeds maximum length of {0} characters";

        public static string Format(string template, params object[] args) 
            => string.Format(template, args);
    }
}