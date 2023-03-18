using System;
using System.Collections.Generic;

namespace AplikasiPemesananMakanan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi menu makanan
            List<MenuItem> menuMakanan = new List<MenuItem>()
            {
                new MenuItem("Nasi Goreng", 15000),
                new MenuItem("Mie Goreng", 12000),
                new MenuItem("Nasi Campur", 20000),
                new MenuItem("Sate Ayam", 10000)
            };

            // Inisialisasi menu minuman
            List<MenuItem> menuMinuman = new List<MenuItem>()
            {
                new MenuItem("Es Teh", 5000),
                new MenuItem("Es Jeruk", 6000),
                new MenuItem("Jus Alpukat", 10000),
                new MenuItem("Jus Mangga", 8000)
            };

            // Tampilkan menu makanan
            Console.WriteLine("Menu Makanan:");
            foreach (MenuItem makanan in menuMakanan)
            {
                Console.WriteLine("{0} - Rp. {1}", makanan.Nama, makanan.Harga);
            }

            // Tampilkan menu minuman
            Console.WriteLine("\nMenu Minuman:");
            foreach (MenuItem minuman in menuMinuman)
            {
                Console.WriteLine("{0} - Rp. {1}", minuman.Nama, minuman.Harga);
            }

            // Meminta input dari user
            Console.WriteLine("\nSilakan pilih menu makanan:");
            int indexMakanan = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("Silakan pilih menu minuman:");
            int indexMinuman = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("Silakan masukkan jumlah pesanan:");
            int jumlahPesanan = Convert.ToInt32(Console.ReadLine());

            // Menghitung total harga pesanan
            int totalHarga = menuMakanan[indexMakanan].Harga + menuMinuman[indexMinuman].Harga;
            totalHarga *= jumlahPesanan;

            // Tampilkan informasi pesanan dan total harga
            Console.WriteLine("\nAnda memesan {0} {1} dan {2} {3}.", 
                jumlahPesanan, menuMakanan[indexMakanan].Nama, 
                jumlahPesanan, menuMinuman[indexMinuman].Nama);
            Console.WriteLine("Total harga: Rp. {0}", totalHarga);
        }
    }

    // Class MenuItem
    class MenuItem
    {
        public string Nama { get; set; }
        public int Harga { get; set; }

        public MenuItem(string nama, int harga)
        {
            Nama = nama;
            Harga = harga;
        }
    }
}
