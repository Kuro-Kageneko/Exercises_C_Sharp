using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises_C_Sharp
{
    class ExerciseElement
    {
        public string Name = string.Empty;
        public Action Method = blind;
        public bool IsMarked = false;
        public bool? FinishState = null;
        public int VideoID = -1;

        static void blind(){}
    }
}