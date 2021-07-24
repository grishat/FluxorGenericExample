using Fluxor;
using FluxorGenericExample.Pages;
using FluxorGenericExample.Store.Actions.ShowDialog;
using FluxorGenericExample.Store.States;

namespace FluxorGenericExample.Store.Reducers
{
    public class ShowDialogActionsReducer
    {
        [ReducerMethod]
        public static IndexState ReduceShowDialogAction<TDialog>(IndexState state, ShowDialogAction<TDialog> action) where TDialog : DialogBase
        {
            var dialog = action.DialogService.Show<TDialog>();
            return state with
            {
                Dialog = dialog,
            };
        }
    }
}
