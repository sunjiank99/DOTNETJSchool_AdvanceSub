using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvanceSub
{
   public  class GoodsOrder
    {

       public string OrderNo;
       public DateTime PayTime;
       public string PickPointName;
       public string RecevieName;
       public string ReceiveTel;
       public byte AddvanceSub;  //是否预分装 0默认未进行预分装 1已经进行预分装
    }

   public class GoodsOrderInfo
   {
       public string GoodsName;
       public int GoodsNum;

   }

   public class AddvanceSubInfo
   {
       public int id;
       public int OrderNum;
       public DateTime CountTime;
       public string Details;
       public int AddvanceSubState;
       public string AddvanceId;
   
   }
}
