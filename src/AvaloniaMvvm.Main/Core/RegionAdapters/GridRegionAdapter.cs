using Avalonia.Controls;
using Prism.Regions;

namespace AvaloniaMvvm.Main.Core.RegionAdapters
{
    public class GridRegionAdapter : RegionAdapterBase<Grid>
    {
        public GridRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) 
            : base(regionBehaviorFactory)
        {
        }

        protected override void Adapt(IRegion region, Grid regionTarget)
        {
            region.Views.CollectionChanged += (sender, e) => {
                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add) {
                    foreach (IControl item in e.NewItems) { 
                        regionTarget.Children.Add(item);
                    }
                }
                if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove) {
                    foreach (IControl item in e.OldItems) { 
                        regionTarget.Children.Remove(item);
                    }                    
                }
            };
        }

        protected override IRegion CreateRegion() 
            => new SingleActiveRegion() {
                
            };
    }
}