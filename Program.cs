const int biayaAdministrasi = 2000;

Console.Write("Nama pelanggan: ");
string namaPelanggan = Console.ReadLine()!;

Console.Write("Nama dokumen: ");
string namaDokumen = Console.ReadLine()!;

Console.Write("Jumlah halaman: ");
int jumlahHalaman = Convert.ToInt32(Console.ReadLine());

Console.Write("Harga per halaman: ");
int hargaPerHalaman = Convert.ToInt32(Console.ReadLine());

int subtotal = jumlahHalaman * hargaPerHalaman;
int totalBayar = subtotal + biayaAdministrasi;

Console.WriteLine("\n=== RINCIAN PENCETAKAN ===");
Console.WriteLine("Nama pelanggan = " + namaPelanggan);
Console.WriteLine("Nama dokumen = " + namaDokumen);
Console.WriteLine("Jumlah halaman = " + jumlahHalaman);
Console.WriteLine("Harga per halaman = " + hargaPerHalaman);
Console.WriteLine("Subtotal = " + subtotal);
Console.WriteLine("Biaya administrasi = " + biayaAdministrasi);
Console.WriteLine("Total bayar = " + totalBayar);