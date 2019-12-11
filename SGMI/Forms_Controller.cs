using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SGMI
{
    public class Forms_Controller
    {
        public static bool maximizado;
        public static Size screen_size;

        private static Panel container = null;
        internal static Stack<Form> forms_abertos = null;
        
        public static void Start_Controller(Panel container_)
        {
            Process[] processos = Process.GetProcessesByName(Application.ProductName);
            foreach (Process p in processos) { if (p.StartTime != Process.GetCurrentProcess().StartTime) { p.Kill(); } }
            forms_abertos = new Stack<Form>();
            container = container_;
        }

        public static void Abrir(Form form)
        {
            if (form != null)
            {
                form.TopLevel = false;
                form.Size = container.Size;
                forms_abertos.Push(form);
                container.Controls.Add(form);
                form.Size = container.Size;
                form.Show();
            }
        }

        public static void Abrir_Anterior()
        {
            if (forms_abertos != null && forms_abertos.Count > 0)
            {
                Form form = forms_abertos.Peek();
                form.TopLevel = false;
                form.Size = container.Size;
                if (!container.Controls.Contains(form)) container.Controls.Add(form);
                form.Show();
            }
        }

        public static void Esconder(Form form) { form.Hide(); }

        public static void Fechar_Recente()
        {
            if (forms_abertos != null && forms_abertos.Count > 0)
            {
                Form form = forms_abertos.Peek();
                form.Close();
                forms_abertos.Pop();
            }
        }

        public static void Fechar_Todos()
        {
            if (forms_abertos != null)
            {
                int cont_forms = forms_abertos.Count;
                for (int i = 0; i < cont_forms; i++)
                {
                    Fechar_Recente();
                }
            }
        }

        public static bool Está_Aberto(string form_name)
        {
            if (forms_abertos != null)
            {
                foreach (Form f in forms_abertos) { if (f.Name.ToUpper().Contains(form_name.ToUpper())) { return true; } }
            }
            return false;
        }

        public static void Redimensionar_Janelas()
        {
            if (forms_abertos != null)
            {
                foreach (Form f in forms_abertos)
                {
                    f.Size = container.Size;
                    //if (f is frm_Dashboard) (f as frm_Dashboard).Redimensionar();
                }
            }
        }
    }
}