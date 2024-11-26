using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPCRUD.View
{
    public interface IUserView
    {
        string UserID { get; set; }       
        string UserName { get; set; }    
        string Email { get; set; }       
        string Nick { get; set; }         
        string CPF { get; set; }          
        DateTime DataCadastro { get; set; }  


        string SerachValue {  get; set; }
        bool IsEdit {  get; set; }
        bool isSucessful {  get; set; }
        string Message { get; set; }


        event EventHandler SearchEvent;   
        event EventHandler AddNewEvent;   
        event EventHandler EditEvent;     
        event EventHandler DeleteEvent;   
        event EventHandler SaveEvent;     
        event EventHandler CancelEvent;

        void SetPetListBindinSource(BindingSource userlist);
        void Show();

    }
}
