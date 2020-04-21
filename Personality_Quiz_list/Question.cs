using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Personality_Quiz_list
{
    public class Question 
    {

        public string Content { get; set; }
        public int PointValue { get; set; }
      


        public Question(string content, int pointValue)
        {
            this.Content = content;
            this.PointValue = pointValue;
           


        }



        public static IList<Question> All { get; set; }

        static Question()
        { 


            List<Question> all = new List<Question>
            {
                new Question("Do you like ruining others people's lives?", 1),
                new Question("Do you like saving the galaxy?", 3),
                new Question("Have you ever accidentally kissed your sister on the lips?", 4),
                new Question("Are you awkward?", 20),
                new Question("Do you enjoy when the bad guys win?", 1)
            };

            All = all;

        }
 
     
    }
}
