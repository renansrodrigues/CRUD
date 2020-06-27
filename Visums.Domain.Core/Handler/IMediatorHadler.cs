using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Visums.Domain.Core.Commands;

namespace Visums.Domain.Core.Handler
{
    public interface IMediatorHadler
    {
        Task SendCommand<T>(T command) where T : Command;


    }
}
