namespace BootstrapBlazor.OnlyServer1.Components
{
    public partial class WMS_Stock
    {
        public Model.Universal.WMS_Stock.outParams init { set; get; } = new Model.Universal.WMS_Stock.outParams();

        public List<Model.Universal.WMS_Stock.outParams> outParams { set; get; } = new List<Model.Universal.WMS_Stock.outParams>();

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        private void onSend()
        {
            outParams.Add(init);
            init = new Model.Universal.WMS_Stock.outParams();
        }
    }
}
