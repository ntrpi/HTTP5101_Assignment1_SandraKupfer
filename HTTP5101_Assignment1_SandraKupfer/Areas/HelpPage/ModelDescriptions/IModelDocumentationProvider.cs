using System;
using System.Reflection;

namespace HTTP5101_Assignment1_SandraKupfer.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}