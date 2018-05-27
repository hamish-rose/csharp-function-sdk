using System.Collections.Generic;

namespace OpenFaas.Http.Function.Sdk
{
   /// <summary>
   /// Request of function call
   /// </summary>
   public class Request
   {
      /// <summary>
      /// Gets or sets the request body
      /// </summary>
      public byte[] Body { get; set; }

      /// <summary>
      /// Gets or sets the request headers
      /// </summary>
      public Dictionary<string, IEnumerable<string>> Headers { get; set; } = new Dictionary<string, IEnumerable<string>>();

      /// <summary>
      /// Gets or sets the query string collection of the request
      /// </summary>
      public Dictionary<string, IEnumerable<string>> Query { get; set; } = new Dictionary<string, IEnumerable<string>>();
   }
}
