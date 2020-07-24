using System;
using Burjo.Abstraction;
using Burjo.Abstraction.Makanan;
using Burjo.Abstraction.Minuman;
using Burjo.Polymorphism;
using Burjo.Polymorphism.Makanan;
using Burjo.Polymorphism.Minuman;

namespace Burjo
{
    public class Program 
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            up:
            Console.Clear();
            Console.WriteLine("DAFTAR MENU BURJO SELALU DIHATI");
            Console.WriteLine("1. Makanan");
            Console.WriteLine("2. Minuman");
            Console.Write("Pilih (1-2) : ");
            int pilih1 = Convert.ToInt32(Console.ReadLine());

            if(pilih1 == 1)
            {
                makanan();
            }
            else if(pilih1 == 2)
            {

                minuman();
            }
            else
            {
                Console.WriteLine("Maaf pilihan anda tidak ada!");
                goto up;
            }
            
        }

        static void makanan()
        {
            pBurjo pburjo;
            aBurjo aburjo;
        up1:
            Console.Clear();
            Console.WriteLine("DAFTAR MENU MAKANAN BURJO SELALU DIHATI");
            Console.WriteLine("1. Nasi Sayur");
            Console.WriteLine("2. Orak Arik");
            Console.WriteLine("3. Soto");
            Console.WriteLine("4. Indomie Telur");
            Console.WriteLine("5. Magelangan");
            Console.WriteLine("6. Nasi Goreng");
            Console.WriteLine("7. Kembali");
            Console.Write("Pilih (1-7) : ");
            int pilMakanan = Convert.ToInt32(Console.ReadLine());
            if (pilMakanan == 1)
            {
                Console.Clear();
                NasiSayur nasiSayur = new NasiSayur();
                nasiSayur.nama = "Nasi Sayur";
                nasiSayur.getNama();
                pburjo = new NasiSayur();
                pburjo.komposisi();
                pburjo.keterangan();

                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up1;
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            else if (pilMakanan == 2)
            {
                Console.Clear();

                OrakArik orakarik = new OrakArik();
                orakarik.nama = "Orak Arik";
                orakarik.getNama();
                pburjo = new OrakArik();
                pburjo.komposisi();
                pburjo.keterangan();

                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up1;
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            else if (pilMakanan == 3)
            {
                Console.Clear();

                Soto soto = new Soto();
                soto.nama = "Soto";
                soto.getNama();
                pburjo = new Soto();
                pburjo.komposisi();
                pburjo.keterangan();

                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up1;
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            else if (pilMakanan == 4)
            {
                Console.Clear();

                IndomieTelur indomietelur = new IndomieTelur();
                indomietelur.nama = "Indomie Telur";
                indomietelur.getNama();
                aburjo = new IndomieTelur();
                aburjo.komposisi();
                aburjo.keterangan();

                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up1;
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            else if (pilMakanan == 5)
            {
                Console.Clear();

                Magelangan magelangan = new Magelangan();
                magelangan.nama = "Magelangan";
                magelangan.getNama();
                aburjo = new Magelangan();
                aburjo.komposisi();
                aburjo.keterangan();

                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up1;
                }
                else
                {
                    System.Environment.Exit(0);
                }

            }
            else if (pilMakanan == 6)
            {
                Console.Clear();

                NasiGoreng nasiGoreng = new NasiGoreng();
                nasiGoreng.nama = "Nasi Goreng";
                nasiGoreng.getNama();
                aburjo = new NasiGoreng();
                aburjo.komposisi();
                aburjo.keterangan();

                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up1;
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            else if(pilMakanan == 7)
            {
                Console.Clear();
                menu();
            }
            else
            {
                Console.WriteLine("Maaf Pilihan Anda Salah!");
                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up1;
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
        }

        static void minuman()
        {
            aBurjo aburjo;
            pBurjo pburjo;
        up2:
            Console.Clear();
            Console.WriteLine("DAFTAR MENU MINUMAN BURJO SELALU DIHATI");
            Console.WriteLine("1. Es Jeruk");
            Console.WriteLine("2. Es Teh");
            Console.WriteLine("3. kratingdeng");
            Console.WriteLine("4. Beng Beng");
            Console.WriteLine("5. Extra Joss");
            Console.WriteLine("6. Marimas");
            Console.WriteLine("7. Kembali");
            Console.Write("Pilih (1-7) : ");
            int pilihminuman = Convert.ToInt32(Console.ReadLine());

            if (pilihminuman == 1)
            {
                Console.Clear();

                EsJeruk esjeruk = new EsJeruk();
                esjeruk.nama = "Es Jeruk";
                esjeruk.getNama();
                pburjo = new EsJeruk();
                pburjo.komposisi();
                pburjo.keterangan();

                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up2;
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            else if (pilihminuman == 2)
            {
                Console.Clear();

                EsTeh esTeh = new EsTeh();
                esTeh.nama = "Es Teah";
                esTeh.getNama();
                pburjo = new EsTeh();
                pburjo.komposisi();
                pburjo.keterangan();

                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up2;
                }
                else
                {
                    System.Environment.Exit(0);
                }

            }
            else if (pilihminuman == 3)
            {
                Console.Clear();

                kratingdeng kratingdeng = new kratingdeng();
                kratingdeng.nama = "Kratingdeng";
                kratingdeng.getNama();
                pburjo = new kratingdeng();
                pburjo.komposisi();
                pburjo.keterangan();

                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up2;
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            else if (pilihminuman == 4)
            {
                Console.Clear();

                BengBeng bengbeng = new BengBeng();
                bengbeng.nama = "Beng Beng";
                bengbeng.getNama();
                aburjo = new BengBeng();
                aburjo.komposisi();
                aburjo.keterangan();

                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up2;
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            else if (pilihminuman == 5)
            {
                Console.Clear();

                ExtraJoss extraJoss = new ExtraJoss();
                extraJoss.nama = "Extra Joss";
                extraJoss.getNama();
                aburjo = new ExtraJoss();
                aburjo.komposisi();
                aburjo.keterangan();

                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up2;
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            else if (pilihminuman == 6)
            {
                Console.Clear();

                Marimas marimas = new Marimas();
                marimas.nama = "Marimas";
                marimas.getNama();
                aburjo = new Marimas();
                aburjo.komposisi();
                aburjo.keterangan();

                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up2;
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            else if(pilihminuman == 7)
            {
                Console.Clear();
                menu();
            }
            else
            {
                Console.WriteLine("Maaf Pilihan Anda Salah!");
                Console.Write("Apakah Anda Ingin Mengulang (Y/N) : ");
                string ulang = Console.ReadLine();
                if (ulang == "y" || ulang == "Y")
                {
                    goto up2;
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }

        }
    }
}
