﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class JpegCompressor : Compressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using JPEG");
        }
    }
}
