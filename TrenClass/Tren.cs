using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.IO;
using System.Net.Sockets;

namespace TrenClass
{
    [Serializable]
    public class Tren
    {
        public int IdTren {get;set;}
        public int ViaInicial {get;set;}
        public int Via {get; set;}
        public int Velocidad {get; set;}
        public int KmInicial {get;set;}
        public int KmFinal {get;set;}
        public int Sentido {get; set;} //1, de 0 a 100, -1 de 100 a 0
        public int Posicion {get;set;}
        // public NetworkStream NSTren { get; set; }

        public Tren()
        {

        }

        public Tren (int IdTren, int ViaInicial, int Velocidad, int KmInicial, int KmFinal, int Sentido/*, NetworkStream NSTren*/)
        {
            this.IdTren = IdTren;
            this.ViaInicial = ViaInicial;
            this.Velocidad = Velocidad;
            this.KmInicial = KmInicial;
            this.KmFinal = KmFinal;
            this.Sentido = Sentido;
            this.Posicion = KmInicial;
            this.Via = ViaInicial;
            // this.NSTren = NSTren;
        }

        public static byte[] Serialize(object obj)
        {
            byte[] bytesPos;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                bytesPos = ms.ToArray();
            }

            return bytesPos;
        }

        public static object Deserialize(byte[] param)
        {
            object obj = null;
            using (MemoryStream ms = new MemoryStream(param))
            {
                IFormatter br = new BinaryFormatter();
                obj = (br.Deserialize(ms) as Tren);
            }

            return obj;
        }
    }
}
