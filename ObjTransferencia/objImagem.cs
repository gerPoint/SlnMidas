using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjTransferencia
{
    public class Imagem
    {
        public int Foto { get; set; }


        public string objImagem { get; set; }
    }
    public class ImagemLista : List<Imagem> { }
}
