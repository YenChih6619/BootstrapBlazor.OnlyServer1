namespace BootstrapBlazor.OnlyServer1.Components
{
    public partial class Sys_Unit
    {
        public Model.Universal.SYS_Unit.outParams init { set; get; } = new Model.Universal.SYS_Unit.outParams();

        public List<Model.Universal.SYS_Unit.outParams> outParams { set; get; } = new List<Model.Universal.SYS_Unit.outParams>();

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        private void onSend()
        {
            outParams.Add(init);
            init = new Model.Universal.SYS_Unit.outParams();
        }
    }
}
