using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaWinClient.Interfaces
{
    public interface IConfig
    {
        IConfiguration Values { get; set; }
    }
}
