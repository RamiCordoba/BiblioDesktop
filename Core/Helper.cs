using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;


namespace BiblioDesktop.Core
{
    public static class Helper
    {
        public static string ObtenerHashSha256(string textoAEncriptar)
        {
            // Create a SHA256   
            using SHA256 sha256Hash = SHA256.Create();
            // ComputeHash - returns byte array  
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(textoAEncriptar));
            // Convert byte array to a string   
            StringBuilder hashObtenido = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                hashObtenido.Append(bytes[i].ToString("x2"));
            }
            return hashObtenido.ToString();
        }

        public static string ObtenerCadenaDeConexion()
        {
            string servidor = Properties.Settings.Default.servidor;
            string bbdd = Properties.Settings.Default.bbdd;
            string usuario = Properties.Settings.Default.usuario;
            string contrasenia = Properties.Settings.Default.contraseña;

            string cadenaConexion = "Server= " + servidor;
            cadenaConexion += " ;Database = " + bbdd;
            cadenaConexion += " ;User Id = " + usuario;
            cadenaConexion += " ;Password = " + contrasenia;
            cadenaConexion += " ;MultipleActiveResultSets = true";
            return cadenaConexion;
        }

        public static Image RecuperarImagenDeArchivoDeRecursos(string nombreImagen)
        {
            Image imagen;
            try
            {
                using (ResourceReader rr = new ResourceReader(@".\Recursos.resources"))
                {
                    string tipoRecurso = "";
                    byte[] bytesArchivo;
                    rr.GetResourceData(nombreImagen, out tipoRecurso, out bytesArchivo);
                    const int OFFSET = 4;
                    int size = BitConverter.ToInt32(bytesArchivo, 0);
                    Bitmap imagenBMP = new Bitmap(new MemoryStream(bytesArchivo, OFFSET, size));
                    imagen = imagenBMP;
                }
                return imagen;
            }
            catch
            { //si no encuentra una imagen, cuando se ejecuta por primera vez, o si borraron
              //accidentalmente el archivo de recursos, crea un nuevo archivo de recursos
                using (ResourceWriter rw = new ResourceWriter(@".\Recursos.resources"))
                {
                    rw.AddResource("Sistema", "VacunDeskTop");
                }
                return null;
            }
        }

        public static byte[] convertirImagenABytes(Image img)
        {
            MemoryStream imagenStream = new MemoryStream();
            img.Save(imagenStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imagenBytes = imagenStream.ToArray();
            return imagenBytes;
        }
        public static Image convertirBytesAImagen(Byte[] arregloImg)
        {
            MemoryStream imagenStream = new MemoryStream(arregloImg);
            Image imagen = Image.FromStream(imagenStream);
            return imagen;
        }
        public static void AlmacenarImagenEnArchivoDeRecursos(Image imagenFondo, string nombreImagen)
        {
            MemoryStream bitmapStream = new MemoryStream();
            Bitmap bmp = new Bitmap(imagenFondo);
            bmp.Save(bitmapStream, ImageFormat.Jpeg);
            using (ResourceWriter rw = new ResourceWriter(@".\Recursos.resources"))
            {
                rw.AddResource(nombreImagen, bitmapStream);
            }
        }
    }
}
