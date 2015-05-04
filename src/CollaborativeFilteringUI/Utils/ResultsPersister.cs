using CollaborativeFiltering;
using CollaborativeFilteringUI.Core.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFilteringUI.Utils
{
    public class ResultsPersister
    {
        public void SaveResults(List<Pair<string, double>> results, string evaluationMethod, string filePath)
        {
            var sb = new StringBuilder();
            sb.AppendLine(evaluationMethod);

            foreach (var result in results)
                sb.AppendLine(result.ToString());

            File.WriteAllText(filePath, sb.ToString());
        }

        public void LoadResults(string filePath, out List<Pair<string, double>> results, out string evaluationMethod)
        {
            var lines = File.ReadAllLines(filePath);
            evaluationMethod = lines[0];

            results = new List<Pair<string, double>>();
            for(int i = 1; i < lines.Length; ++i)
            {
                var split = lines[i].Split(',');
                var value = double.Parse(split[1]);
                results.Add(new Pair<string, double>(split[0], value));
            }
        }
    }
}
