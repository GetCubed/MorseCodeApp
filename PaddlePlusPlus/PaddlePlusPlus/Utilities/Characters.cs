using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaddlePlusPlus.Utilities
{
    public enum Ch
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        I,
        J,
        K,
        L,
        M,
        N,
        O,
        P,
        Q,
        R,
        S,
        T,
        U,
        V,
        W,
        X,
        Y,
        Z,
        _,
        other,

    }


    public static class KeyInput
    {
        


        public static Ch InputToCh(string input)
        {

            switch (input)
            {
                case "zx":
                    return Ch.A;

                case "xzzz":
                    return Ch.B;

                case "xzxz":
                    return Ch.C;
                    
                case "xzz":
                    return Ch.D;
                    
                case "z":
                    return Ch.E;
                    
                case "zzxz":
                    return Ch.F;
                    
                case "xxz":
                    return Ch.G;
                    
                case "zzzz":
                    return Ch.H;
                    
                case "zz":
                    return Ch.I;
                    
                case "zxxx":
                    return Ch.J;
                    
                case "xzx":
                    return Ch.K;
                    
                case "zxzz":
                    return Ch.L;
                    
                case "xx":
                    return Ch.M;
                    
                case "xz":
                    return Ch.N;
                    
                case "xxx":
                    return Ch.O;
                    
                case "zxxz":
                    return Ch.P;
                    
                case "xxzx":
                    return Ch.Q;
                    
                case "zxz":
                    return Ch.R;
                    
                case "zzz":
                    return Ch.S;
                    
                case "x":
                    return Ch.T;
                    
                case "zzx":
                    return Ch.U;
                    
                case "zzzx":
                    return Ch.V;
                    
                case "zxx":
                    return Ch.W;
                    
                case "xzzx":
                    return Ch.X;
                    
                case "xzxx":
                    return Ch.Y;
                    
                case "xxzz":
                    return Ch.Z;
                    
                case " ":
                    return Ch._;
                    
                default:
                    return Ch.other;

            }

        }

        public static bool isValid(Ch input)
        {
            if (input != Ch.other)
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
