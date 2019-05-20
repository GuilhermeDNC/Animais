﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Animais
{
    interface IVoar
    {
        void Voar();
        int AltitudeMaximaEmMetros { get; set; }
        double VelocidadeDoVoo { get; set; }
    }
}
