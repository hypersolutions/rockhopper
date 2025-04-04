using System.Reflection;
using Microsoft.Testing.Platform.CommandLine;
using Microsoft.Testing.Platform.Extensions;
using Microsoft.Testing.Platform.Extensions.Messages;
using Microsoft.Testing.Platform.Extensions.OutputDevice;
using Microsoft.Testing.Platform.Extensions.TestFramework;
using Microsoft.Testing.Platform.Requests;
using Microsoft.Testing.Platform.Services;
#pragma warning disable TPEXP

namespace RockHopper.Engine;

internal sealed class TestingFramework : ITestFramework, IOutputDeviceDataProducer, IDataProducer
{
    private readonly IExtension _extension;
    private readonly IServiceProvider _serviceProvider;
    private readonly IServiceProvider _services;
    private readonly ICommandLineOptions _commandLineOptions;
    private readonly Assembly[] _assemblies;
    private readonly MessageContext _messageContext;
    
    internal TestingFramework(
        IExtension extension,
        IServiceProvider serviceProvider, 
        IServiceProvider services, 
        params Assembly[] assemblies)
    {
        _extension = extension;
        _serviceProvider = serviceProvider;
        _services = services;
        _commandLineOptions = serviceProvider.GetRequiredService<ICommandLineOptions>();
        _assemblies = assemblies;
        _messageContext = new MessageContext(this, serviceProvider.GetOutputDevice());
    }

    public string Uid => _extension.Uid;
    
    public string Version => _extension.Version;
    
    public string DisplayName => _extension.DisplayName;
    
    public string Description => _extension.Description;
    
    public Type[] DataTypesProduced { get; } = [typeof(TestNodeUpdateMessage)];
    
    public Task<bool> IsEnabledAsync() => _extension.IsEnabledAsync();
    
    public Task<CreateTestSessionResult> CreateTestSessionAsync(CreateTestSessionContext context)
    {
        return Task.FromResult(new CreateTestSessionResult { IsSuccess = true });
    }

    public async Task ExecuteRequestAsync(ExecuteRequestContext context)
    {
        switch (context.Request)
        {
            case DiscoverTestExecutionRequest:
            {
                var handler = new TestDiscoveryExecutionHandler(_messageContext, this, context, _assemblies);
                await handler.HandleAsync();
                break;
            }
            case RunTestExecutionRequest:
            {
                var handler = new RunTestExecutionHandler(
                    _messageContext, this, context, _services, _serviceProvider.GetConfiguration(), 
                    _commandLineOptions, _assemblies);
                await handler.HandleAsync();
                break;
            }
        }
    }

    public Task<CloseTestSessionResult> CloseTestSessionAsync(CloseTestSessionContext context)
    {
        return Task.FromResult(new CloseTestSessionResult { IsSuccess = true });
    }
}