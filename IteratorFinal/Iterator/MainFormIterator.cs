using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator
{
    // Main User Interface
    public partial class MainFormIterator : Form
    {
        ConcreteAggregate agg; // Allows us to use the Concrete Agg. class.

        public MainFormIterator()
        {
            InitializeComponent();
            agg = new ConcreteAggregate(); // Calls aggregate
            Iterator iter = agg.CreateIterator(IteratorType.CalendarIterator); // Fills listbox with all months when application is started
            PopulateListBox(iter, lb_months); 
        }
        
        // Useless thing I don't feel like getting rid of.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        // User will press button and the listbox will be populated with all spring months
        private void btn_Spring_Click_1(object sender, EventArgs e)
        {
            Iterator iter = agg.CreateIterator(IteratorType.SpringIterator);
            PopulateListBox(iter, lb_months);
        }

        // User will press button and the listbox will be populated with all summer months
        private void btn_Summer_Click_1(object sender, EventArgs e)
        {
            Iterator iter = agg.CreateIterator(IteratorType.SummerIterator);
            PopulateListBox(iter, lb_months);
        }

        // User will press button and the listbox will be populated with all fall months
        private void btn_fall_Click(object sender, EventArgs e)
        {
            Iterator iter = agg.CreateIterator(IteratorType.FallIterator);
            PopulateListBox(iter, lb_months);
        }

        // User will press button and the listbox will be populated with all winter months
        private void btn_Winter_Click(object sender, EventArgs e)
        {
            Iterator iter = agg.CreateIterator(IteratorType.WinterIterator);
            PopulateListBox(iter, lb_months);
        }

        // User will press button and the listbox will be populated with all months
        private void btn_Calendar_Click(object sender, EventArgs e)
        {
            Iterator iter = agg.CreateIterator(IteratorType.CalendarIterator);
            PopulateListBox(iter, lb_months);
        }

        // Populates the listbox with selected Iterator
        public void PopulateListBox(Iterator iter, ListBox lb)
        {
            lb.Items.Clear();
            for (iter.First(); !iter.IsDone(); iter.Next())
            {
                lb.Items.Add(iter.CurrentItem());
            }
        }
    }
}