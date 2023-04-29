using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAplikasiPerpustakaan.CLASS
{
    class Admin : Pengguna
    {
        public Perpustakaan perpustakaan;

        public Admin(string nama, Perpustakaan perpustakaan) : base(nama)
        {
            this.perpustakaan = perpustakaan;
        }

        public void TambahBuku(int id, string judul, string pengarang, int tahunTerbit)
        {
            perpustakaan.TambahBuku(id, judul, pengarang, tahunTerbit);
        }

        public void TampilkanDaftarBuku()
        {
            perpustakaan.TampilkanDaftarBuku();
        }

        public void UbahStatusBuku(int id, bool status)
        {
            Buku buku = perpustakaan.CariBuku(id);

            if (buku == null)
            {
                Console.WriteLine("Buku tidak ditemukan");
            }
            else
            {
                buku.isDipinjam = status;

                Console.WriteLine("Status buku berhasil diubah");
            }
        }
    }
}
