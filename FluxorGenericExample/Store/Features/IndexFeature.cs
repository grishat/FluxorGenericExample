using Fluxor;
using FluxorGenericExample.Store.States;

namespace FluxorGenericExample.Store.Features
{
    public class IndexFeature : Feature<IndexState>
    {
        public override string GetName() => "Index";

        protected override IndexState GetInitialState() => new IndexState();
    }
}