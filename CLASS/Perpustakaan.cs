using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAplikasiPerpustakaan.CLASS
{
    class Perpustakaan
    {
        public List<Buku> daftarBuku;

        public Perpustakaan()
        {
            daftarBuku = new List<Buku>();
        }

        public void TambahBuku(int id, string judul, string pengarang, int tahunTerbit)
        {
            Buku buku = new Buku();
            buku.id = id;
            buku.judul = judul;
            buku.pengarang = pengarang;
            buku.tahunTerbit = tahunTerbit;
            buku.isDipinjam = false;

            daftarBuku.Add(buku);

            Console.WriteLine("Buku berhasil ditambahkan");
        }

        public void TampilkanDaftarBuku()
        {
            if (daftarBuku.Count == 0)
            {
                Console.WriteLine("Tidak ada buku yang tersedia");
            }
            else
            {
                foreach (Buku buku in daftarBuku)
                {
                    Console.WriteLine("ID: " + buku.id);
                    Console.WriteLine("Judul: " + buku.judul);
                    Console.WriteLine("Pengarang: " + buku.pengarang);
                    Console.WriteLine("Tahun Terbit: " + buku.tahunTerbit);
                    Console.WriteLine("Status: " + (buku.isDipinjam ? "Dipinjam" : "Tersedia"));
                    Console.WriteLine();
                }
            }
        }

        public Buku CariBuku(int id)
        {
            foreach (Buku buku in daftarBuku)
            {
                if (buku.id == id)
                {
                    return buku;
                }
            }

            return null;
        }
    }
}
