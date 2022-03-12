using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekUas
{
    /// <summary>
    /// Main Class
    /// </summary>
    /// <remarks>Class Program dapat menghitung usia berdasarkan tanggal hari ini dikurangi dengan tanggal lahir</remarks>
    class Program
    {
        /// <summary>
        /// Operasi menghitung usia kita sekarang
        /// </summary>
        /// <param name="nama"></param>
        /// <param name="hari"></param>
        /// <param name="bulan"></param>
        /// <param name="tahun"></param>
        /// <param name="ulangtahun"></param>
        /// <param name="hariini"></param>
        /// <returns>Hasil dari operasi pengurangan (subtract) menunjukkan usia sekarang</returns>
        static void Main(string[] args)
        {
            int hari, bulan, tahun;
            Console.Out.WriteLine("                    ------Program Menghitung Usia------                      ");
            Console.Out.WriteLine("===============================================================================");

            try
            {
                Console.Out.Write("Masukkan nama anda: ");
                string nama = Console.In.ReadLine();

                Console.Out.Write("Masukkan tanggal lahir: ");
                hari = Convert.ToInt32(Console.In.ReadLine());

                Console.Out.Write("Masukkan bulan lahir: ");
                bulan = Convert.ToInt32(Console.In.ReadLine());

                Console.Out.Write("Masukkan tahun lahir: ");
                tahun = Convert.ToInt32(Console.In.ReadLine());

                DateTime ulangtahun = new DateTime(tahun, bulan, hari);
                DateTime hariini = DateTime.Now;

                TimeSpan usia = hariini.Subtract(ulangtahun);
                Console.Out.WriteLine("Hallo " + nama + " usia anda saat ini adalah: {0} hari, {1} jam, {2} menit", usia.Days, usia.Hours, usia.Minutes);
                Console.In.ReadLine();

            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Terjadi kesalahan " + e.Message);
            }

        }
    }
}
