using System;
using FortnoxClient.Dto;

namespace FortnoxClient.Extensions
{
    public class FortnoxException : Exception
    {
        public FortnoxException(FortnoxErrorResponse fortnoxError) : base(fortnoxError.ErrorInformation.Message)
        {
            FortnoxError = fortnoxError;
        }

        public FortnoxErrorResponse FortnoxError { get; }
    }
}