﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zhp.Models;

namespace zhp
{
    public partial class UserControl1 : UserControl
    {
        Context context = new Context();

        public UserControl1()
        {
            InitializeComponent();

            Zeneszerzo_Filter();
            lbox_zeneszerzo.DisplayMember = "Név";

            lbox_opera.ValueMember = "OperaId";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Opera_Adatok_Filter();
        }

        private void Opera_Adatok_Filter()
        {
            var selected_zeneszerzoID = ((Zeneszerző)lbox_zeneszerzo.SelectedItem).ZenId;
            lbox_opera.DataSource = (from x in context.OperaAdatoks
                                     where x.ZeneszerzőId == selected_zeneszerzoID
                                     where x.OperaCíme.Contains(txt_opera.Text)
                                     select x).ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Zeneszerzo_Filter();
        }

        private void Zeneszerzo_Filter()
        {
            lbox_zeneszerzo.DataSource = (from x in context.Zeneszerzős
                                          where x.Név.Contains(txt_zenezszerzo.Text)
                                          select x).ToList();
        }

        private void lbox_zeneszerzo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected_zeneszerzoID = ((Zeneszerző)lbox_zeneszerzo.SelectedItem).ZenId;
            var operak = from x in context.OperaAdatoks
                         where x.ZeneszerzőId == selected_zeneszerzoID
                         select x;
            lbox_opera.DataSource = operak.ToList();
            lbox_opera.DisplayMember = "OperaCíme";
        }

        private void btn_opera_add_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            if (newUserForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int max_ID = 0;
            foreach (var opad in context.OperaAdatoks)
            {
                if (opad.OperaId >= max_ID)
                {
                    max_ID = opad.OperaId;
                }
            }
            max_ID++;

            var selected_zeneszerzoID = ((Zeneszerző)lbox_zeneszerzo.SelectedItem).ZenId;
            OperaAdatok operaAdatok = new OperaAdatok()
            {
                OperaId = max_ID,
                ZeneszerzőId = selected_zeneszerzoID,
                OperaCíme = newUserForm.txt_cim.Text,
                Éneknyelv = newUserForm.txt_nyelv.Text,
                ŐsbemutatóÉve = newUserForm.txt_osbem.Text
            };

            context.OperaAdatoks.Add(operaAdatok);
            try
            {
                context.SaveChanges();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            Opera_Adatok_Filter();
        }

        private void btn_remove_opera_Click(object sender, EventArgs e)
        {
            DeleteUserForm delete_User_Form = new DeleteUserForm();
            if (delete_User_Form.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            int torolni_opera_ID = Convert.ToInt32(lbox_opera.SelectedValue);

            var torolni_opera = from x in context.OperaAdatoks
                                where x.OperaId == torolni_opera_ID
                                select x;
            context.OperaAdatoks.Remove(torolni_opera.FirstOrDefault());
            context.SaveChanges();
            Opera_Adatok_Filter();
        }
    }
}
