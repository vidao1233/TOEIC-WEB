﻿namespace toeic_web.ViewModels.Vocabulary
{
    public class VocabularyUpdateModel
    {
        public Guid idTopic { get; set; }
        public Guid professorId { get; set; }
        public string engWord { get; set; }
        public string? pronunciation { get; set; }
        public string? wordType { get; set; }
        public string meaning { get; set; }
    }
}
