using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groep9_SE7
{
    public partial class ConfirmationForm : Form
    {
        private ReisForm form;
        private OutdoorParadise context;
        private List<string> gekozen_klanten = new List<string>();
        private List<int> ids = new List<int>();
        private Travel_planned travel;
        private List<string> gekozen_ecur = new List<string>();
        private List<int> excu_ids = new List<int>();

        public ConfirmationForm(ReisForm f, OutdoorParadise context, List<string> gekozen_klanten, List<int> ids, Travel_planned travel_Planned, List<string> gekozen_ecur, List<int> excu_ids, double prijss)
        {
            InitializeComponent();
            this.gekozen_klanten.Clear();
            this.ids.Clear();
            this.form = f;
            this.context = context;
            this.gekozen_klanten.AddRange(gekozen_klanten);
            this.ids.AddRange(ids);
            this.travel = travel_Planned;
            this.gekozen_ecur = gekozen_ecur;
            this.excu_ids.AddRange(excu_ids);
            price_lbl.Text = prijss + "$ Per person!";

            tprice_lbl.Text = (prijss * gekozen_klanten.Count) + "$";

            displaydetails();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cust_lbl_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.form.Close();

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            foreach(int i in ids)
            {
                Travel_planned t = new Travel_planned()
                {
                    Date_start = travel.Date_start,
                    Date_end = travel.Date_end,
                    Travel_product = travel.Travel_product,
                    Customer = i
                };
                this.context.Travel_planned.Add(t);
                this.context.SaveChanges();

                addex(t);



            }
            

            
            MessageBox.Show("Done!");
            
        } 
            
        
        private void addex(Travel_planned t)
        {
            if (excu_ids.Count > 0)
            {
                foreach (int x in excu_ids)
                {
                    this.context.Excursion_planned.Add(new Excursion_planned { Excursion = x, Travel_planned = t.Travel_plan_ID });
                }
                this.context.SaveChanges();

            }


        }
        private void edit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displaydetails()
        {
            dest_out_lbl.Text = this.context.Travel_product.SingleOrDefault(s => s.Trav_prod_ID == this.travel.Travel_product).Desciption;
            start_lbl.Text = this.travel.Date_start.ToString("yyyy-MM-dd");
            endDate_out_lbl.Text = this.travel.Date_end.ToString("yyyy-MM-dd");
            Cust_out_lbl.Text = "";
            excur_out_lbl.Text = "";

            foreach (string name in gekozen_klanten)
            {
                Cust_out_lbl.Text += name + "\n";
            }

            if(gekozen_ecur.Count ==0 )
            {
                excur_out_lbl.Text = "No extra excursions";
            }
            else
            {
                foreach (string name in gekozen_ecur)
                {
                    excur_out_lbl.Text += name + "\n";
                }
            }
            


        }

        

        
    }
}
