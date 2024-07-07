﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    public class TelefonoBasico : Telefono
    {
        public bool TieneRadioFM { get; set; }
        public bool TieneLinterna { get; set; }

        public void MostrarInformacionBasico()
        {
            MostrarInfo();
            Console.WriteLine($"Tiene Radio FM: {TieneRadioFM}, Tiene Linterna: {TieneLinterna}");
        }
    }
}
