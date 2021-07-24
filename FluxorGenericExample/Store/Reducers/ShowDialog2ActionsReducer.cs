using Fluxor;
using FluxorGenericExample.Pages;
using FluxorGenericExample.Store.Actions.ShowDialog2;
using FluxorGenericExample.Store.States;

namespace FluxorGenericExample.Store.Reducers
{
    public class ShowDialog2ActionsReducer
    {
        [ReducerMethod]
        public static IndexState ReduceShowDialog2Action<TDialog>(IndexState state, ShowDialog2Action action)
        {
            var dialog = action.DialogService.Show<Dialog2>();
            return state with
            {
                Dialog = dialog,
            };
        }
    }
}
