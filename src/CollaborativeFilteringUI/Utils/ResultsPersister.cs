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
    }
}
