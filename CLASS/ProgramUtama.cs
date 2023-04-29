using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAplikasiPerpustakaan.CLASS
{
    class ProgramUtama
    {
        static void Main(string[] args)
        {
            // Membuat objek perpustakaan
            Perpustakaan perpustakaan = new Perpustakaan();

            // Menambahkan beberapa buku ke daftar perpustakaan
            perpustakaan.TambahBuku(1, "Judul Buku 1", "Pengarang 1", 2000);
            perpustakaan.TambahBuku(2, "Judul Buku 2", "Pengarang 2", 2001);
            perpustakaan.TambahBuku(3, "Judul Buku 3", "Pengarang 3", 2002);

            // Membuat objek admin
            Admin admin = new Admin("Admin1", perpustakaan);

            // Menampilkan daftar buku
            admin.TampilkanDaftarBuku();

            // Menambahkan buku baru
            admin.TambahBuku(4, "Judul Buku 4", "Pengarang 4", 2003);

            // Menampilkan daftar buku
            admin.TampilkanDaftarBuku();

            // Mengubah status buku
            admin.UbahStatusBuku(1, true);

            // Membuat objek peminjam
            Peminjam peminjam = new Peminjam("Peminjam1");

            // Menampilkan daftar buku yang dipinjam
            peminjam.TampilkanDaftarBukuDipinjam();

            // Meminjam buku
            peminjam.PinjamBuku(1);

            // Menampilkan daftar buku yang dipinjam
            peminjam.TampilkanDaftarBukuDipinjam();

            // Mengembalikan buku
            peminjam.KembalikanBuku(1);

            // Menampilkan daftar buku yang dipinjam
            peminjam.TampilkanDaftarBukuDipinjam();
        }
    }
}
