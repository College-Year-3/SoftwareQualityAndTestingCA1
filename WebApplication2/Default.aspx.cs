﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        public InsuranceService Service = new InsuranceService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int vehicleValue = int.Parse(VehichleVal.Text);
            string comp3rd = Comp3rd.Text;
            int age = int.Parse(Age.Text);
            int penPoin = int.Parse(PenP.Text);

            float premium = Service.CalculateQuote(vehicleValue, comp3rd, age, penPoin);

            ResultLab.Text = premium.ToString();
        }

        public class InsuranceService
        {

            public float CalculateQuote(int vehicleValue, string comp3rd, int age, int penPoin)
            {
                float premium = 0;

                // Calculate code here


                return premium;
            }
        }
    }
}