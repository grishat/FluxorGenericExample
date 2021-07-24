using FluxorGenericExample.Pages;
using MudBlazor;

namespace FluxorGenericExample.Store.Actions.ShowDialog
{
    public record ShowDialogAction<TDialog>(IDialogService DialogService)
        where TDialog : DialogBase;
}
