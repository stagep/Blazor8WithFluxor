using Fluxor;

namespace Blazor8WithFluxor.State.ServerCounter;

public class ServerCounterFeature : Feature<ServerCounterState>
{
    public override string GetName() => "ServerCounter";

    protected override ServerCounterState GetInitialState()
    {
        return new ServerCounterState(0);
    }
}