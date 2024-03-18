using System;
using System.IO.Pipes;

namespace opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //opd_3A1(new List<string> { "", "Emma Mulder", "Sara De Groot", "Emma Bakker", "Milan Van Dijk", "Emma Smit", "Daan Meijer", "Julia Visser", "Noah Mulder", "Julia Smit", "Sara Van Dijk", "Levi De Groot", "Tess Visser", "Sem Smit", "Levi Visser", "Sara De Boer" });
            opd_3A2(new Dictionary<string, string>() { { "Abstractie", "Het proces van het weglaten van minder essentiële informatie zodat alleen de meest essentiële kenmerken overblijven." }, { "Algoritme", "Een stapsgewijze procedure voor het uitvoeren van een taak of het berekenen van een waarde." }, { "Array", "Een geordende verzameling elementen, typisch van hetzelfde type." }, { "Class", "Een blauwdruk voor een object in objectgeoriënteerd programmeren." }, { "Encapsulatie", "Een objectgeoriënteerd programmeerprincipe waarbij de interne staat van een object verborgen wordt." }, { "Erfenis", "Het vermogen van een nieuwe klasse om de eigenschappen en methoden van een andere klasse over te nemen." }, { "Framework", "Een set van codebibliotheken en tools die helpen bij het ontwikkelen van software." }, { "Interface", "Een contract in OOP dat definieert welke methodes een klasse moet implementeren." }, { "Iteratie", "Het herhaaldelijk uitvoeren van een set instructies totdat een bepaalde voorwaarde is voldaan." }, { "Namespace", "Een container die wordt gebruikt om sets van andere benoemde entiteiten onder een unieke naam te groeperen." }, { "Polymorfisme", "Het vermogen van verschillende klassen om te reageren op dezelfde boodschap op verschillende manieren." }, { "Recursie", "Een techniek in programmeren waar een functie zichzelf oproept." }, { "Serialize", "Het proces van omzetten van een object naar een formaat dat kan worden opgeslagen of overgedragen." }, { "Syntax", "De set regels die definiëren hoe instructies in een programmeertaal zijn opgebouwd." }, { "Variable", "Een opslaglocatie met een geassocieerde naam en een waarde die kan veranderen tijdens de uitvoering van een programma." } });


        }

        static void opd_3A2(Dictionary<string, string> testData)
        {
            foreach (var key in testData.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("Schrijf het woord waar je de definitie van wilt hebben.");
            string begrip = Console.ReadLine()!;
            Console.WriteLine(testData[begrip]);
        }

        static void opd_3A1(List<string> testData)
        {

            for (int i = 1; i < testData.Count; i++)
            {
                Console.WriteLine($"{i}: {testData[i]}");
            }

            string command = Console.ReadLine()!;

            string[] words = command.Split(' ');

            int x = Int32.Parse(words[2]);

            if (command.Contains("bel contact"))
            {

                Console.WriteLine($"Ik bel {testData[x]}");

            }
            else if (command.Contains("verwijder contact"))
            {

                Console.WriteLine($"Ik verwijder {testData[x]}");

                testData.RemoveAt(x);

                Console.WriteLine(". . .");

                System.Threading.Thread.Sleep(1500);

                Console.WriteLine("Succes! Hier is je nieuwe contact lijst:");

                opd_3A1(testData);



            }
        }
    }
}

