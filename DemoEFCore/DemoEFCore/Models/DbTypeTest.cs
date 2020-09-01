using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEFCore.Models
{
    public class DbTypeTest
    {
        public int id { get; set; }

        public string TestString { get; set; }

        public Decimal TestDecimal { get; set; }
        public Decimal? TestDecimalNull { get; set; }

        public Double TestDouble { get; set; }
        public Double? TestDoubleNull { get; set; }

        public int Testint { get; set; }
        public int? TestIntNull { get; set; }

        public bool Testbool { get; set; }
        public bool? TestboolNull { get; set; }

        public DateTime TestDateTime { get; set; }
        public DateTime? TestDateTimeNull { get; set; }

        public byte TestByte { get; set; }
        public byte? TestByteNull { get; set; }

        public byte[] TestByteA { get; set; }

        public uint TestUnit { get; set; }
        public uint? TestUnitNull { get; set; }

        public short TestShort { get; set; }
        public ushort TestUShort { get; set; }

        public char testChar { get; set; }

    }
}

