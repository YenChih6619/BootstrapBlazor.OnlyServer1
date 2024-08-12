namespace BootstrapBlazor.OnlyServer1.Model
{
    public partial class Universal
    {
        public class SYS_Unit
        {
            public class inParams
            {

            }

            public class outParams
            {
                public int UNIT_ID { set; get; }

                public string UNIT_NO { set; get; }

                public string UNIT_DESC { set; get; }

            }
        }

        public class SYS_Flavor
        {
            public class inParams
            {

            }

            public class outParams
            {
                public int Flavor_ID { set; get; }

                public string Flavor_Name { set; get; }

            }
        }

        public class SYS_Manufacturer
        {
            public class inParams
            {

            }

            public class outParams
            {
                /// <summary>
                /// 製造商 ID
                /// </summary>
                public string Manufacturer_ID { set; get; }

                /// <summary>
                /// 製造商名稱
                /// </summary>
                public string Manufacturer_Name { set; get; }

                /// <summary>
                /// 製造商簡介
                /// </summary>
                public string Manufacturer_Desc { set; get; }

                /// <summary>
                /// 酒廠產地
                /// </summary>
                public string Manufacturer_Origin { set; get; }

                /// <summary>
                /// 酒廠連絡電話
                /// </summary>
                public string Manufacturer_Tel { set; get; }
            }
        }

        public class WMS_Stock
        {
            public class inParams
            {

            }

            public class outParams
            {
                /// <summary>
                /// 製造商 ID
                /// </summary>
                public string Manufacturer_ID { set; get; }

                /// <summary>
                /// 產品名稱
                /// </summary>
                public string Lot_Name { set; get; }

                /// <summary>
                /// 標籤編號
                /// </summary>
                public string Lot_Code { set; get; }

                /// <summary>
                /// 庫存數量
                /// </summary>
                public decimal QTY_NORMAL { set; get; }

                /// <summary>
                /// 單位價格
                /// </summary>
                public decimal QTY_Price { set; get; }

                /// <summary>
                /// 單位成本
                /// </summary>
                public decimal QTY_Cost { set; get; }

                /// <summary>
                /// 風味標籤
                /// </summary>
                public List<int> Flavor { set; get; }

                /// <summary>
                /// 單位 ID
                /// </summary>
                public int UNIT_ID { set; get; }
            }
        }
    }
}
