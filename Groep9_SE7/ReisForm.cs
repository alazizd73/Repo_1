
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groep9_SE7
{
    public partial class ReisForm : Form
    {
        private OutdoorParadise context;
        private int Trav_prod_ID;
        private int min_cap;
        private int max_cap;
        private List<string> gekozen_klanten = new List<string>();
        private List<string> gekozen_excur = new List<string>();
        private int lengte;


        public ReisForm(OutdoorParadise db)
        {
            InitializeComponent();
            this.context = db;
            Travel_product_details_lbl.Hide();

            start_date.Value = DateTime.Now;
            end_date.Value = start_date.Value.AddDays(1);
            HideElements();

            Get_reis_type();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reis_type_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideElements();
            Travel_product_details_lbl.Text = "";
            Travel_product_details_lbl.Text = "Duration          Min_Capacity          Max_Capacity         Children \n\n";
            string gekozen_loc = reis_type_cb.SelectedItem.ToString();
            List<Travel_product> target = context.Travel_product.Where(s => s.Desciption.Equals(gekozen_loc)).ToList();

            foreach (Travel_product t in target)
            {

                Travel_product_details_lbl.Text += t.Length + " days                " + t.Min_capacity + "                                " + t.Max_capacity + "                     " + t.Kids_Allowed;
                this.Trav_prod_ID = t.Trav_prod_ID;
                this.min_cap = t.Min_capacity;
                this.max_cap = t.Max_capacity;
                this.lengte = t.Length;

            }
            Travel_product_details_lbl.Show();
            start_d_lbl.Show();
            start_date.Show();


            gekozen_klanten.Clear();

        }

        private void Get_reis_type()
        {
            List<Travel_product> products = context.Travel_product.ToList();
            foreach (Travel_product t in products)
            {
                reis_type_cb.Items.Add(t.Desciption);
            }

        }

        private void ReisForm_Load(object sender, EventArgs e)
        {

        }

        private void T_pro_lbl_Click(object sender, EventArgs e)
        {

        }

        private void cust_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (gekozen_klanten.Count == this.max_cap)
            {
                MessageBox.Show("No more places!");
            }

            else
            {
                if (gekozen_klanten.Contains(cust_listBox.SelectedItem.ToString()))
                {
                    MessageBox.Show("This customer is already in the list!");
                }
                else
                {
                    gekozen_klanten.Add(cust_listBox.SelectedItem.ToString());
                    last_listbox.Items.Add(cust_listBox.SelectedItem);
                }

            }



        }

        private void Get_Customer_list()
        {
            CC_lbl.Show();
            cust_listBox.Show();
            SC_lbl.Show();

            last_listbox.Show();
            List<Customer> customers = this.context.Customer.Where(s => s.Big_small.Equals('S')).ToList();


            foreach (Customer c in customers)
            {
                cust_listBox.Items.Add(c.ID + " " + c.First_Name + " " + c.Last_Name);
            }



        }

        private void Get_Excursion_list()
        {
            exu1_lbl.Show();
            excu2_lbl.Show();
            undo2_btn.Show();

            excu_listbox.Show();
            sExcu_listbox.Show();

            

            if(excu_listbox.Items.Count == 0)
            {
                List<Excursion> excursions = this.context.Excursion.Where(s => s.Exc_ID > 0).ToList();
                foreach (Excursion c in excursions)
                {

                    excu_listbox.Items.Add(c.Exc_ID + " " + c.Description);
                }
            }
        }

        private void Selected_cust_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void HideElements()
        {

            cust_listBox.Hide();
            CC_lbl.Hide();
            SC_lbl.Hide();

            start_d_lbl.Hide();
            end_d_lbl.Hide();


            start_date.Hide();
            end_date.Hide();

            last_listbox.Hide();
            undo_btn.Hide();
            conf_btn.Hide();
            exu1_lbl.Hide();
            excu2_lbl.Hide();
            undo2_btn.Hide();

            excu_listbox.Hide();
            sExcu_listbox.Hide();

        }

        private void start_date_ValueChanged(object sender, EventArgs e)
        {

            if (start_date.Value < DateTime.Today)
            {
                MessageBox.Show("Select a correct date!");

            }
            else
            {
                end_d_lbl.Show();
                end_date.Show();
            }


        }

        private void end_date_ValueChanged(object sender, EventArgs e)
        {
            
            bool check = end_date.Value <= start_date.Value;
            if (check)
            {
                MessageBox.Show("End date is not correct!");
            }

            else
            {
                Get_Customer_list();
                undo_btn.Show();
                conf_btn.Show();
                Get_Excursion_list();
            }

        }

        private void undo_btn_Click(object sender, EventArgs e)
        {
            if (gekozen_klanten.Count > 0)
            {
                last_listbox.Items.RemoveAt(gekozen_klanten.Count - 1);
                gekozen_klanten.RemoveAt(gekozen_klanten.Count - 1);
            }

            else
                MessageBox.Show("List is empty!");


        }

        private void last_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void conf_btn_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            List<string> f = new List<string>();
            List<int> excu_ids = new List<int>();
            List<string> f2 = new List<string>();


            if (gekozen_klanten.Count != 0 && gekozen_klanten.Count >= this.min_cap)
            {

                foreach (string s in gekozen_klanten)
                {

                    f.AddRange(s.Split(' '));

                }
                foreach (string s in f)
                {
                    Regex re = new Regex(@"^\d+$");

                    if (re.IsMatch(s))
                    {

                        ids.Add(int.Parse(s));

                    }
                }

                Travel_planned t = new Travel_planned();

                t.Date_start = start_date.Value;
                t.Date_end = end_date.Value;
                t.Travel_product = context.Travel_product.SingleOrDefault(s => s.Desciption.Equals(reis_type_cb.SelectedItem.ToString())).Trav_prod_ID;

                foreach (string s in gekozen_excur)
                {

                    f2.AddRange(s.Split(' '));

                }
                foreach (string s in f2)
                {
                    Regex re = new Regex(@"^\d+$");

                    if (re.IsMatch(s))
                    {

                        excu_ids.Add(int.Parse(s));

                    }
                }

                int aantal = (int)(t.Date_end - t.Date_start).TotalDays;

                if (aantal > lengte)
                {
                    MessageBox.Show("Change start or end date! You can only have " + lengte + " days");

                }
                else
                {
                    double prijs = Calcu_price(t, excu_ids);
                    ConfirmationForm conf = new ConfirmationForm(this, this.context, gekozen_klanten, ids, t, gekozen_excur, excu_ids, prijs);

                    conf.ShowDialog();
                }


            }

            else
            {
                MessageBox.Show("Add more people!");
            }
        }

        private double Calcu_price(Travel_planned t, List<int> excu_idss)
        {
            double prijs = this.context.Travel_product.SingleOrDefault(s => s.Trav_prod_ID == t.Travel_product).Price;
            if (excu_idss.Count > 0)
            {
                foreach (int i in excu_idss)
                {
                    prijs += this.context.Excursion.SingleOrDefault(s => s.Exc_ID == i).Price;
                }
            }

           
        

           return prijs;
        }

        private void excu_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(gekozen_excur.Count == 2)
            {
                MessageBox.Show("Choose 2 items!");
            }
            else
            {
                if (gekozen_excur.Contains(excu_listbox.SelectedItem.ToString()))
                {
                    MessageBox.Show("This item is already in the list!");
                }
                else
                {
                    gekozen_excur.Add(excu_listbox.SelectedItem.ToString());
                    sExcu_listbox.Items.Add(excu_listbox.SelectedItem);
                }
            }
                

            
        }

        private void sExcu_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void undo2_btn_Click(object sender, EventArgs e)
        {
            if (gekozen_excur.Count > 0)
            {
                sExcu_listbox.Items.RemoveAt(gekozen_excur.Count - 1);
                gekozen_excur.RemoveAt(gekozen_excur.Count - 1);
            }

            else
                MessageBox.Show("List is empty!");
        }
    }
}