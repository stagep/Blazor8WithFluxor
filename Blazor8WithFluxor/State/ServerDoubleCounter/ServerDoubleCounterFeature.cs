using Fluxor;

namespace Blazor8WithFluxor.State.ServerDoubleCounter;

public class ServerDoubleCounterFeature : Feature<ServerDoubleCounterState>
{
    public override string GetName() => "ServerDoubleCounter";

    protected override ServerDoubleCounterState GetInitialState()
    {
        return new ServerDoubleCounterState(0);
    }
}