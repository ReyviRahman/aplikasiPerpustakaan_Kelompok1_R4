using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAplikasiPerpustakaan.CLASS
{
    class Peminjam : Pengguna
    {
        public List<Buku> bukuDipinjam;

        public Peminjam(string nama)
        : base(nama)
        {
            bukuDipinjam = new List<Buku>();
        }

        public void PinjamBuku(int id)
        {
            Perpustakaan perpustakaan = new Perpustakaan();
            Buku buku = perpustakaan.CariBuku(id);

            if (buku == null)
            {
                Console.WriteLine("Buku tidak ditemukan");
            }
            else if (buku.isDipinjam)
            {
                Console.WriteLine("Buku sedang dipinjam");
            }
            else
            {
                buku.isDipinjam = true;
                bukuDipinjam.Add(buku);

                Console.WriteLine("Buku berhasil dipinjam");
            }
        }

        public void TampilkanDaftarBukuDipinjam()
        {
            if (bukuDipinjam.Count == 0)
            {
                Console.WriteLine("Anda tidak sedang meminjam buku");
            }
            else
            {
                Console.WriteLine("Daftar Buku yang Dipinjam:");
                foreach (Buku buku in bukuDipinjam)
                {
                    Console.WriteLine("ID: " + buku.id);
                    Console.WriteLine("Judul: " + buku.judul);
                    Console.WriteLine("Pengarang: " + buku.pengarang);
                    Console.WriteLine("Tahun Terbit: " + buku.tahunTerbit);
                    Console.WriteLine();
                }
            }
        }

        public void KembalikanBuku(int id)
        {
            Buku buku = bukuDipinjam.Find(x => x.id == id);

            if (buku == null)
            {
                Console.WriteLine("Buku tidak ditemukan");
            }
            else
            {
                buku.isDipinjam = false;
                bukuDipinjam.Remove(buku);

                Console.WriteLine("Buku berhasil dikembalikan");
            }
        }
    }
}

