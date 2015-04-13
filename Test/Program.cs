using System;
using FP.Enterprise.Collections;

namespace Test
{
    public class Example
    {
        public static void Main()
        {
            // Create a list of parts.

           var parts = new FP.Enterprise.Collections.CustomList<Part>();

            // Add parts to the list.
            parts.Add(new Part() {PartName = "crank arm", PartId = 1234});
            parts.Add(new Part() {PartName = "chain ring", PartId = 1334});
            parts.Add(new Part() {PartName = "regular seat", PartId = 1434});
            parts.Add(new Part() {PartName = "banana seat", PartId = 1444});
            parts.Add(new Part() {PartName = "cassette", PartId = 1534});
            parts.Add(new Part() {PartName = "shift lever", PartId = 1634});

            var threadSafeList = new TheadSafeList<Part>(parts);

            // Write out the parts in the list. This will call the overridden ToString method 
            // in the Part class.
            Console.WriteLine();
            foreach (var aPart in threadSafeList)
            {
                Console.WriteLine(aPart);
            }

            // Check the list for part #1734. This calls the IEquitable.Equals method 
            // of the Part class, which checks the PartId for equality.
            Console.WriteLine("\nContains(\"1734\"): {0}",
                threadSafeList.Contains(new Part { PartId = 1734, PartName = "" }));

            // Insert a new item at position 2.
            Console.WriteLine("\nInsert(2, \"1834\")");
            threadSafeList.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });


            //Console.WriteLine(); 
            foreach (var aPart in threadSafeList)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine("\nParts[3]: {0}", parts[3]);

            Console.WriteLine("\nRemove(\"1534\")");

            // This will remove part 1534 even though the PartName is different, 
            // because the Equals method only checks PartId for equality.
            parts.Remove(new Part() {PartId = 1534, PartName = "cogs"});

            Console.WriteLine();
            foreach (var aPart in threadSafeList)
            {
                Console.WriteLine(aPart);
            }
            Console.WriteLine("\nRemoveAt(3)");
            // This will remove the part at index 3.
            parts.RemoveAt(3);

            Console.WriteLine();
            foreach (var aPart in threadSafeList)
            {
                Console.WriteLine(aPart);
            }

            Console.ReadLine();
        }
    }
}