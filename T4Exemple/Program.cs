using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Exemple
{
    class Program
    {
        static void Main(string[] args)
        {

            Stagiaire s = new Stagiaire();


            // RunTime generator
            //var pageContent = new RuntimeTextTemplate1().TransformText();
            //System.IO.File.WriteAllText("outputPage.cs", pageContent);


            RuntimeTextTemplate1 t = new RuntimeTextTemplate1();
            t.Session =   new Dictionary<string, object>();
            t.Session["TimesToRepeat"] = 5;
            // Add other parameter values to t.Session here.
            t.Initialize(); // Must call this to transfer values.
            string resultText = t.TransformText();
            System.IO.File.WriteAllText("outputPage.cs", resultText);

        }
    }
}
