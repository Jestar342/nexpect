using System;
using System.Collections.Generic;

namespace NExpect.Exceptions
{
    public class ExpectationNotMetException : Exception
    {
        protected const string FilterPrefix = "NExpect.";

        public ExpectationNotMetException(string message)
            : base(message)
        {
        }

        public ExpectationNotMetException(string message, object target, object @object)
            : base(string.Format("{0} {1} {2}", target, message, @object))
        {
        }

        public override string StackTrace
        {
            get { return FilterStackTrace(); }
        }


        private string FilterStackTrace()
        {
            if (base.StackTrace == null)
                return null;

            var lines = new List<string>(base.StackTrace.Split(Environment.NewLine.ToCharArray()));
            var filteredLines = new List<string>();
            lines.ForEach(line =>
                              {
                                  if (!line.TrimStart("at ".ToCharArray())
                                           .StartsWith(FilterPrefix))
                                      filteredLines.Add(line);
                              });
            return string.Join(Environment.NewLine, filteredLines.ToArray());
        }
    }
}