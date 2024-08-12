using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace BootstrapBlazor.OnlyServer1.Components.Pages
{
    public partial class Index
    {
        [Inject]
        [NotNull]
        private ToastService ToastService { set; get; }

        [Inject]
        [NotNull]
        private PathService PathService { set; get; }

        private CancellationTokenSource? ReadToken { get; set; }

        private static List<string> Images =>
        [
            "./images/Pic0.jpg",
            "./images/Pic1.jpg",
            "./images/Pic2.jpg"
        ];



        protected override void OnInitialized()
        {
            base.OnInitialized();

        }

     
        



    }
}
