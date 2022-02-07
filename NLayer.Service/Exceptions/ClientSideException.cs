using System;

namespace NLayer.Service.Exceptions
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S3925:\"ISerializable\" should be implemented correctly", Justification = "<Pending>")]
    public class ClientSideException : Exception
    {
        public ClientSideException(string exceptionMessage) : base(exceptionMessage)
        {

        }
    }
}
