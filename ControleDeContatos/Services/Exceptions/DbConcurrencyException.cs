﻿using System;

namespace ControleDeContatos.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
     public DbConcurrencyException(string message) : base(message)
        {
        }
    }
}
