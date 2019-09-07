﻿using System.Collections.Generic;

namespace level.app.LevenshteinDistance
{
    public class Input {

        public string reference = string.Empty;
        public List<string> target;

        public Input(string reference, List<string> target)
        {
            this.reference = reference;
            this.target = target;

            CallLevenstheinCalc(reference, target);
        }

        private object CallLevenstheinCalc(string reference, List<string> target)
        {

            var levenLogic = new Logic(reference, target);
            return levenLogic.Calculate(reference, target);
        }
    };

}
