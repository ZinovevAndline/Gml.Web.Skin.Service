using Gml.Web.Skin.Service.Core.Extensions.Application;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddFilter(static (_, level) => level >= LogLevel.Error);
builder.CreateService().Run();
