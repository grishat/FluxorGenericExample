using Fluxor;
using FluxorGenericExample.Store.Actions.HideDialog;
using FluxorGenericExample.Store.States;

namespace FluxorGenericExample.Store.Reducers
{
    public class HideDialogActionsReducer
    {
        [ReducerMethod]
        public static IndexState ReduceHideDialogAction(IndexState state, HideDialogAction _)
        {
            state.Dialog?.Close();
            return state with
            {
                Dialog = null,
            };
        }
    }
}
