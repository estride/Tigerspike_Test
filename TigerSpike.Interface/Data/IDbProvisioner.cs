using System;
using System.Collections.Generic;
using System.Text;

namespace TigerSpike.Interface.Data
{
    public interface IMovieService
    {
        void ProvisionDatabase(string connectionString);
    }
}
