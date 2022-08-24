using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MSRegister_CoRe.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Root
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string DominantHand { get; set; }
        public string BirthGender { get; set; }
        public string StudyId { get; set; }
        public List<Test> Tests { get; set; }
    }

    public class Score
    {
        public int ID { get; set; }
        public int Question { get; set; }
        public int CurrentScore { get; set; }
        public string ScoreStamp { get; set; }
        public string TimeRemaining { get; set; }
        public string Answer { get; set; }
        public string CorrectAnswer { get; set; }
        public string SymbolChoice { get; set; }
        public string VoiceCommand { get; set; }
        public string DeviceOrientation { get; set; }
    }

    public class Test
    {
        [Key]
        public int TestID { get; set; }
        public int id { get; set; }
        public int NumberOfQuestions { get; set; }
        public int SuccessfulAnswers { get; set; }
        public string EndStamp { get; set; }
        public List<Score> Scores { get; set; }
    }


}
