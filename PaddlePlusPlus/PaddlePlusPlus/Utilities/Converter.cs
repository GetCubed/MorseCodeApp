using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaddlePlusPlus.Utilities
{

    public static partial class Converter
    {

        public static Ch morseStringToEnum (string morseString)
        {
            switch (morseString)
            {
                case "zx":  return Ch.A;
                case "xzzz": return Ch.B;
                case "xzxz": return Ch.C;
                case "xzz": return Ch.D;
                case "z": return Ch.E;
                case "zzxz": return Ch.F;
                case "xxz": return Ch.G;
                case "zzzz": return Ch.H;
                case "zz": return Ch.I;
                case "zxxx": return Ch.J;
                case "xzx": return Ch.K;
                case "zxzz": return Ch.L;
                case "xx": return Ch.M;
                case "xz": return Ch.N;
                case "xxx": return Ch.O;
                case "zxxz": return Ch.P;
                case "xxzx": return Ch.Q;
                case "zxz": return Ch.R;
                case "zzz": return Ch.S;
                case "x": return Ch.T;
                case "zzx": return Ch.U;
                case "zzzx": return Ch.V;
                case "zxx": return Ch.W;
                case "xzzx": return Ch.X;
                case "xzxx": return Ch.Y;
                case "zzxx": return Ch.Z;
                case "": return Ch._;
                default:return Ch.other;
            }
        }

        public static void isValidString(string input)
        {
            return;

        }


        public static string EnumToString(Ch enumInput)
        {
            switch (enumInput)
            {
                case Ch.A: return "A";
                case Ch.B: return "B";
                case Ch.C: return "C";
                case Ch.D: return "D";
                case Ch.E: return "E";
                case Ch.F: return "F";
                case Ch.G: return "G";
                case Ch.H: return "H";
                case Ch.I: return "I";
                case Ch.J: return "J";
                case Ch.K: return "K";
                case Ch.L: return "L";
                case Ch.M: return "M";
                case Ch.N: return "N";
                case Ch.O: return "O";
                case Ch.P: return "P";
                case Ch.Q: return "Q";
                case Ch.R: return "R";
                case Ch.S: return "S";
                case Ch.T: return "T";
                case Ch.U: return "U";
                case Ch.V: return "V";
                case Ch.W: return "W";
                case Ch.X: return "X";
                case Ch.Y: return "Y";
                case Ch.Z: return "Z";
                case Ch._: return " ";
                default: return "#";
            }

        }

    }
}
