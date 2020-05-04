Partial Public Class _Default :   Page
{  
 Inherits Page
    Private int conteo=0;

    Protected void Page_Load(Object sender,EventArgs e) 
        {
        // Verificamos que no sea un postback del webform
        If (!IsPostBack)
                {
                    txtConteo.Text="0";
                }
        }
    
    Protected void btnIncrementa_Click(Object sender, eventArgs e)
        {
        conteo++;
        txt.Conteo.Text =conteo.ToString();
        }
}