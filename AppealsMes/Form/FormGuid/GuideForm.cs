using AppealsMes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appeals_Mes
{
    public partial class GuideForm : Form
    {
        public GuideForm()
        {
            InitializeComponent();
        }
        public void StatusBtn_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<StatusFormAddRed>().Any())
            {
                new StatusFormAddRed().Show();
            }
        }

        private void PrioritietBtn_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<PrioritiesFormAddRed>().Any())
            {
                new PrioritiesFormAddRed().Show();
            }
        }

        private void PostBtn_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<PostFormAddRed>().Any())
            {
                new PostFormAddRed().Show();
            }
        }

        private void MethodTreatmentBtn_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<MethodTreatmentFormAddRed>().Any())
            {
                new MethodTreatmentFormAddRed().Show();
            }
        }

        private void DistrictBtn_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<DistrictFormAddRed>().Any())
            {
                new DistrictFormAddRed().Show();
            }
        }

        private void TypeAppealBtn_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<TypeAppealFormAddRed>().Any())
            {
                new TypeAppealFormAddRed().Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<StatusFormAddRed>().Any())
                StatusBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            else
                StatusBtn.IconChar = FontAwesome.Sharp.IconChar.BookOpen;

            if (!Application.OpenForms.OfType<PrioritiesFormAddRed>().Any())
                PrioritietBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            else
                PrioritietBtn.IconChar = FontAwesome.Sharp.IconChar.BookOpen;

            if (!Application.OpenForms.OfType<PostFormAddRed>().Any())
                PostBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            else
                PostBtn.IconChar = FontAwesome.Sharp.IconChar.BookOpen;

            if (!Application.OpenForms.OfType<MethodTreatmentFormAddRed>().Any())
                MethodTreatmentBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            else
                MethodTreatmentBtn.IconChar = FontAwesome.Sharp.IconChar.BookOpen;

            if (!Application.OpenForms.OfType<DistrictFormAddRed>().Any())
                DistrictBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            else
                DistrictBtn.IconChar = FontAwesome.Sharp.IconChar.BookOpen;

            if (!Application.OpenForms.OfType<TypeAppealFormAddRed>().Any())
                TypeAppealBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            else
                TypeAppealBtn.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
        }
    }
}
