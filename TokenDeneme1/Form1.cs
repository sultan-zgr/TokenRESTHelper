using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TokenDeneme1.Shared;

namespace TokenDeneme1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        [Authorize]
        [HttpPost]
        private async void button1_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.GetAll();
            txtResponce.Text = RestHelper.BeautifyJson(responce); //JSON Formatı
        }
        private async void bGet_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Get(txtId.Text);
            txtResponce.Text = RestHelper.BeautifyJson(response);

        }
        private async void bPost_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Post(txtName.Text, txtJob.Text);
            txtResponce.Text = RestHelper.BeautifyJson(response);
        }

        private async void bPut_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Put(txtId.Text, txtName.Text, txtJob.Text);
            txtResponce.Text = RestHelper.BeautifyJson(response);
        }

        private async void bDelete_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Delete(txtId.Text);
            txtResponce.Text = response;
        }
    }
}
