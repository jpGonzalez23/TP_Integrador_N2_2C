﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class FileManagerException : Exception
    {
        public FileManagerException(string? message) : base(message)
        {
        }

        public FileManagerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
