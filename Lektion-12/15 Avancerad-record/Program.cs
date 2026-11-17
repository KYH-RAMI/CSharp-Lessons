using Avancerad_Record_jämförelse;
using System;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
System.Text.Encoding uTF8 = System.Text.Encoding.UTF8;
Console.InputEncoding = uTF8;

#region header
Console.WriteLine("15 Record vs klass – jämförelse");
Console.Title = "15 Record vs klass – jämförelse";
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

// ---------- 1. Två record med SAMMA innehåll ----------
var r1 = new KursResultat("Alice", 85);
var r2 = new KursResultat("Alice", 85);

Console.WriteLine("--- RECORD ---");
Console.WriteLine($"r1 = {r1}");
Console.WriteLine($"r2 = {r2}");
Console.WriteLine($"r1 == r2 ?  {r1 == r2}");      // ✅ True
Console.WriteLine($"r1.Equals(r2) ?  {r1.Equals(r2)}");

// ---------- 2. Två klass-objekt med SAMMA innehåll ----------
var k1 = new KursResultatKlass("Alice", 85);
var k2 = new KursResultatKlass("Alice", 85);

Console.WriteLine("\n--- KLASS ---");
Console.WriteLine($"k1 = {k1}");
Console.WriteLine($"k2 = {k2}");
Console.WriteLine($"k1 == k2 ?  {k1 == k2}");      // ❌ False
Console.WriteLine($"k1.Equals(k2) ?  {k1.Equals(k2)}"); // ❌ False

// ---------- 3. Samma referens → alltid lika ----------
var k3 = k1;
Console.WriteLine($"\nk1 == k3 ?  {k1 == k3}");       // ✅ True (samma objekt)

// ---------- 4. Olika innehåll → olika i båda fallen ----------
var r3 = new KursResultat("Bob", 90);
var k4 = new KursResultatKlass("Bob", 90);
Console.WriteLine($"\nr1 == r3 ?  {r1 == r3}");       // False
Console.WriteLine($"k1 == k4 ?  {k1 == k4}");         // False

// ---------- 5. Lägg i HashSet – skillnaden blir tydlig ----------
Console.WriteLine("\n--- HashSet (dubbletter) ---");
var recordSet = new HashSet<KursResultat> { r1, r2 };
var klassSet = new HashSet<KursResultatKlass> { k1, k2 };
Console.WriteLine($"Record-set antal: {recordSet.Count}");  // 1
Console.WriteLine($"Klass-set antal:  {klassSet.Count}");   // 2

// ---------- 6. with-uttryck fungerar bara på record ----------
var r4 = r1 with
{
    Betyg = 90
};
Console.WriteLine($"\nwith: {r4}");
Console.WriteLine($"Original oförändrat: {r1}");

#region footer
Console.WriteLine("\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion

namespace Avancerad_Record_jämförelse
{
    // ===== RECORD (värdetyp-semantik) =====
    record KursResultat(string Student, int Betyg);

    // ===== KLASS (referenstyp-semantik) =====
    class KursResultatKlass
    {
        public string Student
        {
            get; set;
        }
        public int Betyg
        {
            get; set;
        }

        public KursResultatKlass(string student, int betyg)
        {
            Student = student;
            Betyg = betyg;
        }

        // Vi override:ar ToString för att utskriften ska bli jämförbar
        public override string ToString()
            => $"KursResultatKlass {{ Student = {Student}, Betyg = {Betyg} }}";
    }
}