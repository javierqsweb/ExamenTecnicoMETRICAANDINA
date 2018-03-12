using System;
using System.Collections.Generic;

namespace SlnExamen
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDevolverCadena_Click(object sender, EventArgs e)
        {
            ChangeString changeString = new ChangeString();

            string  testArray = txtCadena.Text;
            var caracter = new List<string>();

            for (int i = 0; i < testArray.Length; ++i)
            {
                caracter.Add(changeString.build(testArray[i]));
            }

           lblResultado.Text = String.Concat(caracter); 
        }
    }
}