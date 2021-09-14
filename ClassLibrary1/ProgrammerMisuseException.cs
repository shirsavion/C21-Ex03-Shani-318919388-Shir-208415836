using System;

namespace FacebookApp
{
    namespace Logic
    {
        public class ProgrammerMisuseException : Exception
        {
            public string MisUsedObj { get; }

            public string FullMessage
            {
                get 
                {
                    return "Programmer misuse of logic." + Environment.NewLine + this.Message + Environment.NewLine + MisUsedObj + " missing.";
                }
            }

            public ProgrammerMisuseException() { }

            public ProgrammerMisuseException(string i_Message)
                : base(i_Message) { }

            public ProgrammerMisuseException(string i_Message, string i_MisUsedClassType)
                : this(i_Message)
            {
                MisUsedObj = i_MisUsedClassType;
            }
        }
    }
}
