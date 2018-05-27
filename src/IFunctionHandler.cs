using System.Threading.Tasks;

namespace OpenFaas.Http.Function.Sdk
{
   /// <summary>
   /// Describes the interface for serverless function invocation. Implementers will be able to executed
   /// by the serverless framework
   /// </summary>
   public interface IFunctionHandler
   {
      /// <summary>
      /// Handle a function invocation request, and respond asyncronously 
      /// </summary>
      /// <param name="request"><see cref="Request"/> function request</param>
      /// <returns><see cref="Task{Response}"/> function response</returns>
      Task<Response> HandleAsync(Request request);
   }
}
