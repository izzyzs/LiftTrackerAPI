# LiftTrackerAPI
GraphQL project with *no tutorial* just docs and AI for assisting thought process

### Error:
  * I'm getting an error that's really confusing:

```bash

❯ dotnet run
Building...
Unhandled exception. System.InvalidOperationException: Unable to resolve service for type 'HotChocolate.AspNetCore.Serialization.IHttpResponseFormatter' while attempting to activate 'HotChocolate.AspNetCore.HttpGetSchemaMiddleware'.
   at Microsoft.Extensions.Internal.ActivatorUtilities.ConstructorMatcher.CreateInstance(IServiceProvider provider)
   at Microsoft.Extensions.Internal.ActivatorUtilities.CreateInstance(IServiceProvider provider, Type instanceType, Object[] parameters)
   at Microsoft.AspNetCore.Builder.UseMiddlewareExtensions.ReflectionMiddlewareBinder.CreateMiddleware(RequestDelegate next)
   at Microsoft.AspNetCore.Builder.ApplicationBuilder.Build()
   at Microsoft.AspNetCore.Builder.EndpointRouteBuilderExtensions.MapGraphQL(IEndpointRouteBuilder endpointRouteBuilder, PathString path, String schemaName)
   at Microsoft.AspNetCore.Builder.EndpointRouteBuilderExtensions.MapGraphQL(IEndpointRouteBuilder endpointRouteBuilder, String path, String schemaName)
   at Program.<Main>$(String[] args) in /Users/ismaelz/Dropbox/Ben_n_Family/Ismael_Z/Documents/Career/Programming/Web/ASP.NET/LiftTrackerAPI/Program.cs:line 20

```
