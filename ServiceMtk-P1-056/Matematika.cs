using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_056
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Matematika : IMatematika
    {
        public int Bagi(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);



                //scr default
                //throw new Exception(ex.Message) //pesan error setelah default
                //throw new FaultException("Pesan Salah"); //utk melakukan pesan eror yg dkirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public int Kali(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //scr default
                //throw new Exception(ex.Message) //pesan error setelah default
                //throw new FaultException("Pesan Salah"); //utk melakukan pesan eror yg dkirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public int Kurang(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //scr default
                //throw new Exception(ex.Message) //pesan error setelah default
                //throw new FaultException("Pesan Salah"); //utk melakukan pesan eror yg dkirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public int Tambah(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //scr default
                //throw new Exception(ex.Message) //pesan error setelah default
                //throw new FaultException("Pesan Salah"); //utk melakukan pesan eror yg dkirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        //TKoordinat:nama methodnya, a, b = input sprti int.
        //Membuat koordinat hasil lalu menjumlahkan xa dengan xb, ya dengan yb lalu dimasukkan ke hasil
        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {
            try
            {
                Koordinat hasil = new Koordinat();
                hasil.X = a.X + b.X;
                hasil.Y = a.Y + b.Y;
                return hasil;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //scr default
                //throw new Exception(ex.Message) //pesan error setelah default
                //throw new FaultException("Pesan Salah"); //utk melakukan pesan eror yg dkirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }
    }
}