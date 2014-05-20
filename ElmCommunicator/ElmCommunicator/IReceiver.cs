﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;

namespace ElmCommunicator
{
    public interface IReceiver
    {
        ICommunicationMessage Parse(string received);

        void Process(ICommunicationMessage message);
    }
}