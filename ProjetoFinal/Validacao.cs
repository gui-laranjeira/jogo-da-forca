﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Validacao
    {
        public static bool LetraValida(char jogada)
        {
            //todas as letras do alfabeto
            char[] alfabeto = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P', 'Q', 'R','S','T','U','V','W', 'X', 'Y', 'Z', };

            if (alfabeto.Contains(jogada))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
