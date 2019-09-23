using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitution.Models
{
    public class FeedbackCoach: Feedback
    {
        public override string PrintFeedback()
        {
            return $"Coach feedback last quarter: {FeedbackText}";
        }
    }
}
