using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaddlePlusPlus.Models;

namespace PaddlePlusPlus.DAL
{
    interface IRootObjectRepository
    {
        Task<Rootobject> GetRootObjectByTextAsync(string text, string speed, string tone);
    }
}
