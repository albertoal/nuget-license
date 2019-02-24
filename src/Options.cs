using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace NugetUtility
{

    [Verb("file", HelpText = "Encrypt File(s) Or Folder(s")]
    public class PackageOptions
    { //normal options here

        [Option('i', "input", HelpText = "Project Directory")]
        public string ProjectDirectory { get; set; }

        [Usage(ApplicationAlias = "dotnet-nuget")]
        public static IEnumerable<Example> Examples
        {
            get
            {
                return new List<Example>() {
                new Example("encrypt folder", new PackageOptions { ProjectDirectory = "~/Projects/project/project.csproj" }),
                };
            }
        }
    }

}