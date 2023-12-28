namespace EducationalApp.DataTypes
{
    public class DataTypesInfo
    {
        public void ShowAllDataTypes(string test)
        {
            Console.WriteLine("Primite Types \\o/\n");

            sbyte a = sbyte.MaxValue;
            sbyte b = 100;
            sbyte c = default;

            byte d = byte.MaxValue;
            short e = short.MaxValue;
            ushort f = ushort.MaxValue;
            int g = int.MaxValue;
            uint h = uint.MaxValue;
            long i = long.MaxValue;
            ulong j = ulong.MaxValue;
            float k = float.MaxValue;
            double l = double.MaxValue;
            decimal m = decimal.MaxValue;
            char n = 'A';
            string o = "abc";
            bool p = true;

            Console.WriteLine("sbyte a: " + a);
            Console.WriteLine("sbyte b: " + b);
            Console.WriteLine("sbyte c: " + c);

            Console.WriteLine("byte d: " + d);
            Console.WriteLine("short e: " + e);
            Console.WriteLine("ushort f: " + f);
            Console.WriteLine("int g: " + g);
            Console.WriteLine("uint h: " + h);
            Console.WriteLine("long i: " + i);
            Console.WriteLine("ulong j: " + j);
            Console.WriteLine("float k: " + k);
            Console.WriteLine("double l: " + l);
            Console.WriteLine("decimal m: " + m);
            Console.WriteLine("char n: " + n);
            Console.WriteLine("string o: " + o);
            Console.WriteLine("bool p: " + p);
            Console.WriteLine();
        }

    }
}
