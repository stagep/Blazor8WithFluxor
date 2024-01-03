using Fluxor;

namespace Blazor8WithFluxor.State.ServerDoubleCounter;

public static class ServerDoubleCounterActionsReducers
{
    [ReducerMethod]
    public static ServerDoubleCounterState OnIncrementServerCounterAction(ServerDoubleCounterState state, IncrementServerDoubleCounterAction action)
    {
        return state with
        {
            CurrentCount = state.CurrentCount + 2
        };
    }
}