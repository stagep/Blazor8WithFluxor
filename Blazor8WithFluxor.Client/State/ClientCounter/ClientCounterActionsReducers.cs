using Fluxor;

namespace Blazor8WithFluxor.Client.State.ClientCounter;

public static class ClientCounterActionsReducers
{
    [ReducerMethod]
    public static ClientCounterState OnIncrementClientCounterAction(ClientCounterState state, IncrementClientCounterAction action)
    {
        return state with
        {
            CurrentCount = state.CurrentCount + 1
        };
    }
}