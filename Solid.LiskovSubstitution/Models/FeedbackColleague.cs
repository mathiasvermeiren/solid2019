using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitution.Models
{
    public class FeedbackColleague: Feedback
    {
        public override int CalculateTotalScore()
        {
            var sumOfScores = ScoreCommunication + ScoreTechnicalSkills;

            return sumOfScores / 2;
        }

        public override string PrintFeedback()
        {
            return $"The consultant was scored {CalculateTotalScore()} by the colleague.\n" +
                   $"Feedback last quarter: {FeedbackText}";
        }

    }
}
