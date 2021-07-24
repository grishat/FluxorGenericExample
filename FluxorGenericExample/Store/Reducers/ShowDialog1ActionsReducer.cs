using Fluxor;
using FluxorGenericExample.Pages;
using FluxorGenericExample.Store.Actions.ShowDialog1;
using FluxorGenericExample.Store.States;

namespace FluxorGenericExample.Store.Reducers
{
    public class ShowDialog1ActionsReducer
    {
        [ReducerMethod]
        public static IndexState ReduceShowDialog1Action(IndexState state, ShowDialog1Action action)
        {
            var dialog = action.DialogService.Show<Dialog1>();
            return state with
            {
                Dialog = dialog,
            };
        }
    }
}
