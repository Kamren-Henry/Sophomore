using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public enum IteratorType { SpringIterator, SummerIterator, FallIterator, WinterIterator, CalendarIterator}
    
    // Stores all of the Information
    public abstract class Aggregate
    {

    }

    // Contains all of my information, my strings, and my create iterator methods
    public class ConcreteAggregate : Aggregate
    {
        public string[] months; // array of months

        public ConcreteAggregate()
        {
            months = new string[13];

            months[1] = "January";
            months[2] = "Febuary";
            months[3] = "March";
            months[4] = "April";
            months[5] = "May";
            months[6] = "June";
            months[7] = "July";
            months[8] = "August";
            months[9] = "September";
            months[10] = "October";
            months[11] = "November";
            months[12] = "December";
        }
    
        // String Indexing
    public string this[int i]
    {
        get
        {
            return months[i];
        }
    }

        public Iterator CreateIterator(IteratorType it)

        {
            Iterator retVal;
            switch (it)
            {
                case IteratorType.SpringIterator:
                    retVal = CreateSpringIterator(this);
                    break;

                case IteratorType.SummerIterator:
                    retVal = CreateSummerIterator(this);
                    break;

                case IteratorType.FallIterator:
                    retVal = CreateFallIterator(this);
                    break;

                case IteratorType.WinterIterator:
                    retVal = CreateWinterIterator(this);
                    break;

                case IteratorType.CalendarIterator:
                    retVal = CreateCalendarIterator(this);
                    break;

                default:
                    retVal = CreateCalendarIterator(this);
                    break;
            }
            return retVal;
        }

        private Iterator CreateSpringIterator(ConcreteAggregate agg)
        {
            return new SpringIterator(agg);
        }

        private Iterator CreateSummerIterator(ConcreteAggregate agg)
        {
            return new SummerIterator(agg);
        }

        private Iterator CreateFallIterator(ConcreteAggregate agg)
        {
            return new FallIterator(agg);
        }

        private Iterator CreateWinterIterator(ConcreteAggregate agg)
        {
            return new WinterIterator(agg);
        }

        private Iterator CreateCalendarIterator(ConcreteAggregate agg)
        {
            return new CalendarIterator(agg);
        }


    }
}
