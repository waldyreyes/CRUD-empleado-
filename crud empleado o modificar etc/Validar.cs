using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_empleado_o_modificar_etc
{
    class Validar
    {
        public void soloLetras(KeyPressEventArgs l)
        {
            if (char.IsLetter(l.KeyChar ))
            {
                l.Handled = false;
            }
            else if(char.IsSeparator(l.KeyChar ))
            {
                l.Handled = false;

            }
            else if(char.IsControl (l.KeyChar ))
            {
                l.Handled = false;

            }
            else
            {
                l.Handled = true;
            }
        }

        public void soloNumeros(KeyPressEventArgs l)
        {
            if (char.IsDigit(l.KeyChar))
            {
                l.Handled = false;
            }
            else if (char.IsSeparator(l.KeyChar))
            {
                l.Handled = false;
            }
            else if (char.IsControl(l.KeyChar))
            {
                l.Handled = false;

            }
            else if (l.KeyChar.ToString().Equals("."))
            {
                l.Handled = false;
            }
            else
            {
                l.Handled = true;
            }
        }
    }
}
