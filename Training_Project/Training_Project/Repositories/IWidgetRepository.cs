using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    interface IWidgetRepository
    {
        P2PWidget MyWidget{get;set;}
        P2PWidgetContent MyWidgetContent_0{get;set;}
        P2PWidgetContent MyWidgetContent_1 { get; set; }

        void CreateWidgetContent(int ID);

        
    }
}
