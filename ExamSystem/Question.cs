using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    class Question
    {
        string Header;
        string Body;
        int mark;

        public Question()
        {

        }
    }

    class TrueFalse:Question
    {

    }
    class Choose : Question
    {

    }
    class ChooseAll : Question
    {

    }

}

