using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.features._6._0
{
    public class ReadOnlyAutoproperties
    {
        public ICollection<Double> Temperatures { get; } = new List<Double> { 38.5, 40 };
        public MadridDotNetAssistant MemberExperience { get;} = MadridDotNetAssistant.NewBie;
    }

    public enum MadridDotNetAssistant
    {
        NewBie,
        Experienced,
        God
    }
}
