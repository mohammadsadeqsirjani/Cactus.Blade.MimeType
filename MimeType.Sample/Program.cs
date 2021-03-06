﻿using Cactus.Blade.MimeType;
using System;

namespace MimeType.Sample
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            //Using static method get mime Type From the Resources
            var name = Mime.GetMimeType("ami");
            Console.WriteLine("ami = " + name);

            IMime mimeType = new Mime();
            var mimeType1 = mimeType.Get("3dml");
            Console.WriteLine("3dml = " + mimeType1);

            var mimeType2 = mimeType["z3"];
            Console.WriteLine("z3 = " + mimeType2);
        }
    }
}
