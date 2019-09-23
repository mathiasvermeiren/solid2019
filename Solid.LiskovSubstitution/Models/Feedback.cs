using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitution.Models
{
    public class Feedback
    {
        public string FeedbackText { get; set; }
        public string PreviewText { get; set; }
        public int ScoreCommunication { get; set; }
        public int ScoreTechnicalSkills { get; set; }
        public int ScoreInitiativeApproach { get; set; }

        public virtual int CalculateTotalScore()
        {
            var sumOfScores = ScoreCommunication + ScoreTechnicalSkills + ScoreInitiativeApproach;

            return sumOfScores / 3;
        }

        public virtual string PrintFeedback()
        {
            return $"The consultant was scored {CalculateTotalScore()} by the client.\n" +
                   $"Feedback last quarter: {FeedbackText}\n" +
                   $"Preview next quarter: {PreviewText}";
        }

    }
}
