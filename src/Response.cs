using System.Collections.Generic;

namespace OpenFaas.Http.Function.Sdk
{
   /// <summary>
   /// Response of a function call
   /// </summary>
   public class Response
   {
      /// <summary>
      /// Gets or sets the response body 
      /// </summary>
      public byte[] Body { get; set; }

      /// <summary>
      /// Gets or sets the status code of the response
      /// </summary>
      public int StatusCode { get; set; }

      /// <summary>
      /// Gets or sets the request headers
      /// </summary>
      public Dictionary<string, IEnumerable<string>> Headers { get; set; } = new Dictionary<string, IEnumerable<string>>();
   }
}
