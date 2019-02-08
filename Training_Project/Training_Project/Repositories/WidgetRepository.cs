using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    class WidgetRepository:IWidgetRepository
    {

        public P2PWidget MyWidget{get;set;}

        public P2PWidgetContent MyWidgetContent_0{get;set;}

        public P2PWidgetContent MyWidgetContent_1{get;set;}

        public WidgetRepository(int ID)
        {
            
            CreateWidgetContent(ID);
        }

        public void CreateWidgetContent(int ID)
        {
            this.MyWidget = new P2PWidget(ID,Utilities.Random(),Enumerators.Answere.n,Utilities.getJson("json.txt"),Utilities.Random(),"",Enumerators.Answere.n,Enumerators.Answere.n,Utilities.Random());
            this.MyWidgetContent_0 = new P2PWidgetContent(ID, Enumerators.LanguageCode.en_CA, Utilities.getJson("json.txt"));
            this.MyWidgetContent_1 = new P2PWidgetContent(ID,Enumerators.LanguageCode.fr_CA,Utilities.getJson("json.txt"));
        }
    }
}
