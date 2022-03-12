using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302200016
{
    internal class KodeBuah_1
    {
		public static KodeBuah_1 Apel = new KodeBuah_1("Apel", "A000");
		public static KodeBuah_1 Aprikot = new KodeBuah_1("Aprikot", "B000");
		public static KodeBuah_1 Alpukat = new KodeBuah_1("Alpukat", "C000");
		public static KodeBuah_1 Pisang = new KodeBuah_1("Pisang", "D000");
		public static KodeBuah_1 Paprika = new KodeBuah_1("Paprika", "E000");
		public static KodeBuah_1 Blackberry = new KodeBuah_1("Blackberry", "F000");
		public static KodeBuah_1 Ceri = new KodeBuah_1("Ceri", "H000");
		public static KodeBuah_1 Kelapa = new KodeBuah_1("Kelapa", "I000");
		public static KodeBuah_1 Jagung = new KodeBuah_1("Jagung", "J000");
		public static KodeBuah_1 Kurma = new KodeBuah_1("Kurma", "K000");
		public static KodeBuah_1 Durian = new KodeBuah_1("Durian", "L000");
		public static KodeBuah_1 Anggur = new KodeBuah_1("Anggur", "M000");
		public static KodeBuah_1 Melon = new KodeBuah_1("Melon", "N000");
		public static KodeBuah_1 Semangka = new KodeBuah_1("Semangka", "O000");

		public static KodeBuah_1[] JenisBuah = new KodeBuah_1[]
		{
			Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka
		};

		private string Buah;
		private string Kode;

		public KodeBuah_1(string buah, string kode)
		{
			this.Buah = buah;
			this.Kode = kode;
		}

		public static KodeBuah_1 GetKodeBuah(string kode)
		{
			foreach (var b in JenisBuah)
			{
				if (b.GetKode() == kode) return b;
			}
			return null;
		}

		public string GetBuah()
		{
			return Buah;
		}

		public string GetKode()
		{
			return Kode;
		}
	}
}