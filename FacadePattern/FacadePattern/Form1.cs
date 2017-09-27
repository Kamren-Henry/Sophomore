using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadePattern
{
    public partial class Form1 : Form
    {
        // Create Class Variables
        Facade facade = new Facade();
        Airline airline = new Airline();
        Hotel hotel = new Hotel();
        RentalCar rentalcar = new RentalCar();

        // Constructor
        public Form1()
        {
            InitializeComponent();
            facade.Total(); 
            totalPriceLabel.Text = ("$" + facade.total); // Sets total price label
        }

        // If the checkbox is checked it doubles the ftl and sets it to ftl_rb
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_chk_btn.Checked)
            {
                facade.flt_rb = (facade.flt * 2);
                fltPriceLabel.Text = ("$" + facade.flt_rb);
                facade.Total();
                totalPriceLabel.Text = ("$" + facade.total);
            }
            else
            {
                facade.flt_rb = 0;
                fltPriceLabel.Text = ("$" + facade.flt);
                facade.Total();
                totalPriceLabel.Text = ("$" + facade.total);
            }
        }

        // sets flt = to the southwest price
        private void sw_r_btn_CheckedChanged(object sender, EventArgs e)
        {
            rb_chk_btn.Checked = false;
            fltPriceLabel.Text = ("$" + airline.southwest);
            facade.flt = airline.southwest;
            facade.Total();
            totalPriceLabel.Text = ("$" + facade.total);
        }
        
        // sets flt = to the united price
        private void utd_r_btn_CheckedChanged(object sender, EventArgs e)
        {
            rb_chk_btn.Checked = false;
            fltPriceLabel.Text = ("$" + airline.united);
            facade.flt = airline.united;
            facade.Total();
            totalPriceLabel.Text = ("$" + facade.total);
        }

        // sets flt = to the delta price
        private void dlt_r_btn_CheckedChanged(object sender, EventArgs e)
        {
            rb_chk_btn.Checked = false;
            fltPriceLabel.Text = ("$" + airline.delta);
            facade.flt = airline.delta;
            facade.Total();
            totalPriceLabel.Text = ("$" + facade.total);
        }

        // sets htl = to the hilton price
        private void hltn_r_btn_CheckedChanged(object sender, EventArgs e)
        {
            htlPriceLabel.Text = ("$" + hotel.hilton);
            facade.htl = hotel.hilton;
            facade.Total();
            totalPriceLabel.Text = ("$" + facade.total);
        }

        // sets htl = to the marriott price
        private void mrtt_r_btn_CheckedChanged(object sender, EventArgs e)
        {
            htlPriceLabel.Text = ("$" + hotel.marriott);
            facade.htl = hotel.marriott;
            facade.Total();
            totalPriceLabel.Text = ("$" + facade.total);
        }

        // sets htl = to the holidy inn price
        private void hld_r_btn_CheckedChanged(object sender, EventArgs e)
        {
            htlPriceLabel.Text = ("$" + hotel.holiday);
            facade.htl = hotel.holiday;
            facade.Total();
            totalPriceLabel.Text = ("$" + facade.total);
        }

        // sets rtl = to nothing because the user has selected no car.
        private void nocar_r_btn_CheckedChanged(object sender, EventArgs e)
        {
            rtlPriceLabel.Text = ("$" + rentalcar.none);
            facade.rtl = rentalcar.none;
            facade.Total();
            totalPriceLabel.Text = ("$" + facade.total);
        }

        // sets rtl = to the car price
        private void car_r_btn_CheckedChanged(object sender, EventArgs e)
        {
            rtlPriceLabel.Text = ("$" + rentalcar.car);
            facade.rtl = rentalcar.car;
            facade.Total();
            totalPriceLabel.Text = ("$" + facade.total);
        }

        // sets rtl = to the suv price
        private void suv_r_btn_CheckedChanged(object sender, EventArgs e)
        {
            rtlPriceLabel.Text = ("$" + rentalcar.suv);
            facade.rtl = rentalcar.suv;
            facade.Total();
            totalPriceLabel.Text = ("$" + facade.total);
        }

        // sets rtl = to the luxury price
        private void luxry_r_btn_CheckedChanged(object sender, EventArgs e)
        {
            rtlPriceLabel.Text = ("$" + rentalcar.luxury);
            facade.rtl = rentalcar.luxury;
            facade.Total();
            totalPriceLabel.Text = ("$" + facade.total);
        }

        // Updates the total price label if it did not update correctly
        private void totalPriceLabel_Click(object sender, EventArgs e)
        {
            facade.Total();
            totalPriceLabel.Text = ("$" + facade.total);
        }

        // Chooses the cheapest options for travel
        private void bestBtn_Click(object sender, EventArgs e)
        {
            dlt_r_btn.Checked = true;
            fltPriceLabel.Text = ("$" + airline.delta);
            facade.flt = airline.delta;

            mrtt_r_btn.Checked = true;
            htlPriceLabel.Text = ("$" + hotel.marriott);
            facade.htl = hotel.marriott;

            nocar_r_btn.Checked = true;
            rtlPriceLabel.Text = ("$" + rentalcar.none);
            facade.rtl = rentalcar.none;

            rb_chk_btn.Checked = false;

            facade.Total();
            totalPriceLabel.Text = ("$" + facade.total);
        }
    }
}