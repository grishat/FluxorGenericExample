using MudBlazor;

namespace FluxorGenericExample.Store.States
{
    public record IndexState(
        bool IsBusy = default,
        IDialogReference? Dialog = default);
}
