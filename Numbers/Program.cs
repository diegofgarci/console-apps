using System;
using static System.Console;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            String linea = new String('-', 100);
            WriteLine(linea);
            Write(format: "{0,-30} {1,-30}", arg0: "Type", arg1: "Bytes");
            Write(format: "{0,-30} {1,-30} {2}", arg0: "Max", arg1: "Min", arg2: "\n");
            WriteLine(linea);

            //sbyte
            Write(format: "{0,-30} {1,-30:N0}", arg0: typeof(sbyte), arg1: sizeof(sbyte));
            Write(format: "{0,-30} {1,-30:N0} {2}", arg0: sbyte.MaxValue, arg1: sbyte.MinValue, arg2: "\n");

            //byte
            Write(format: "{0,-30} {1,-30:N0}", arg0: typeof(byte), arg1: sizeof(byte));
            Write(format: "{0,-30} {1,-30:N0} {2}", arg0: byte.MaxValue, arg1: byte.MinValue, arg2: "\n");

            //short
            Write(format: "{0,-30} {1,-30:N0}", arg0: typeof(short), arg1: sizeof(short));
            Write(format: "{0,-30} {1,-30:N0} {2}", arg0: short.MaxValue, arg1: short.MinValue, arg2: "\n");

            //usshort
            Write(format: "{0,-30} {1,-30:N0}", arg0: typeof(ushort), arg1: sizeof(ushort));
            Write(format: "{0,-30} {1,-30:N0} {2}", arg0: ushort.MaxValue, arg1: ushort.MinValue, arg2: "\n");

            //int 
            Write(format: "{0,-30} {1,-30:N0}", arg0: typeof(int), arg1: sizeof(int));
            Write(format: "{0,-30} {1,-30:N0} {2}", arg0: int.MaxValue, arg1: int.MinValue, arg2: "\n");

            //uint
            Write(format: "{0,-30} {1,-30:N0}", arg0: typeof(uint), arg1: sizeof(uint));
            Write(format: "{0,-30} {1,-30:N0} {2}", arg0: uint.MaxValue, arg1: uint.MinValue, arg2: "\n");

            //long
            Write(format: "{0,-30} {1,-30:N0}", arg0: typeof(long), arg1: sizeof(long));
            Write(format: "{0,-30} {1,-30:N0} {2}", arg0: long.MaxValue, arg1: long.MinValue, arg2: "\n");

            //ulong
            Write(format: "{0,-30} {1,-30:N0}", arg0: typeof(ulong), arg1: sizeof(ulong));
            Write(format: "{0,-30} {1,-30:N0} {2}", arg0: ulong.MaxValue, arg1: ulong.MinValue, arg2: "\n");

            //float
            Write(format: "{0,-30} {1,-30:N0}", arg0: typeof(float), arg1: sizeof(float));
            Write(format: "{0,-30} {1,-30:E} {2}", arg0: float.MaxValue, arg1: float.MinValue, arg2: "\n");

            //double
            Write(format: "{0,-30} {1,-30:N0}", arg0: typeof(double), arg1: sizeof(double));
            Write(format: "{0,-30:E} {1,-30:E} {2}", arg0: double.MaxValue, arg1: double.MinValue, arg2: "\n");

            //decimal
            Write(format: "{0,-30} {1,-30:N0}", arg0: typeof(decimal), arg1: sizeof(decimal));
            Write(format: "{0,-30:E} {1,-30:E} {2}", arg0: decimal.MaxValue, arg1: decimal.MinValue, arg2: "\n");




        }
    }
}
