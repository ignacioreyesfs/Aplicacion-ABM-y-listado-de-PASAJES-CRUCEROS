using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Modelos
{
    class Usuario
    {
        public Int32 id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public Int16 intentosFallidos { get; set; }
        public Int16 habilitado { get; set; }

        public Usuario(Int32 id, string userName, string password, Int16 intentosFallidos, Int16 habilitado)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.intentosFallidos = intentosFallidos;
            this.habilitado = habilitado;
        }

        public void Deshabilitar()
        {
            habilitado = 0;
        }

        public void AumentarIntentoFallido()
        {
            intentosFallidos += 1;

            if (intentosFallidos == 3 && EstaHabilitado())
            {
                Deshabilitar();
            }
        }

        public void LoginExitoso()
        {
            this.refrescarIntento();
        }

        private void refrescarIntento()
        {
            intentosFallidos = 0;
        }


        public bool ValidarPassword(string text)
        {
            string passwordAChequear = toStringSHA256(text);
            return this.password == passwordAChequear;
        }


        public bool EstaHabilitado()
        {
            return habilitado == 1;
        }

        private string toStringSHA256(string text) 
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed sha256 = new SHA256Managed();
            byte[] textSha256 = sha256.ComputeHash(bytes);

            string hashString = string.Empty;
            foreach (byte by in textSha256)
            {
                    hashString += String.Format("{0:x2}", by);
            }

            return hashString.ToUpper();
 
        }
    }
}
