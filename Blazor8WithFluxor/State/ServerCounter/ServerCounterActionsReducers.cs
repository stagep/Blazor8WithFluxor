using Fluxor;

namespace Blazor8WithFluxor.State.ServerCounter;

public static class ServerCounterActionsReducers
{
    [ReducerMethod]
    public static ServerCounterState OnIncrementServerCounterAction(ServerCounterState state, IncrementServerCounterAction action)
    {
        return state with
        {
            CurrentCount = state.CurrentCount + 1
        };
    }
}