using Fluxor;

namespace Blazor8WithFluxor.Client.State.ClientCounter;

public class ClientCounterFeature : Feature<ClientCounterState>
{
    public override string GetName() => "ClientCounter";

    protected override ClientCounterState GetInitialState()
    {
        return new ClientCounterState(0);
    }
}