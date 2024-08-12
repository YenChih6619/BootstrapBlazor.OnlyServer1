namespace BootstrapBlazor.OnlyServer1.Components
{
    public partial class Sys_Manufacturerrazor
    {
        public Model.Universal.SYS_Manufacturer.outParams init { set; get; } = new Model.Universal.SYS_Manufacturer.outParams();

        List<Model.Universal.SYS_Manufacturer.outParams> outParams { get; set; } = new List<Model.Universal.SYS_Manufacturer.outParams>();

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }


        private void onSend()
        {
            outParams.Add(init);
            init = new Model.Universal.SYS_Manufacturer.outParams();
        }
    }
}
