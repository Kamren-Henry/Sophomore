using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    // Class that contains all Iterators
    public abstract class Iterator
    {
        protected ConcreteAggregate aggregate;

        public abstract void First();
        public abstract void Next();
        public abstract bool IsDone();
        public abstract string CurrentItem();

    }

    public class ConcreteIterator
    {

    } //empty
    
    // Will return all spring months
    public class SpringIterator: Iterator
    {
        int current_index;

        public SpringIterator(ConcreteAggregate agg)
        {
            aggregate = agg;
        }
        
        public override void First()
        {
            current_index = 1;
        }

        public override void Next()
        {
            current_index++;
        }

        public override bool IsDone()
        {
            return (current_index > 3);
        }

        public override string CurrentItem()
        {
            if (!IsDone())
                return  aggregate.months[current_index];
            else
                throw new Exception();
        }
    }

    // Will return all summer months
    public class SummerIterator : Iterator
    {
        int current_index;

        public SummerIterator(ConcreteAggregate agg)
        {
            aggregate = agg;
        }

        public override void First()
        {
            current_index = 4;
        }
        
        public override void Next()
        {
            current_index++;
        }

        public override bool IsDone()
        {
            return(current_index > 6);
        }

        public override string CurrentItem()
        {
            if (!IsDone())
                return aggregate.months[current_index];
            else
                throw new Exception();
        }
    }

    // Will return all Fall months
    public class FallIterator : Iterator
    {
        int current_index;

        public FallIterator(ConcreteAggregate agg)
        {
            aggregate = agg;
        }

        public override void First()
        {
            current_index = 7;
        }

        public override void Next()
        {
            current_index++;
        }

        public override bool IsDone()
        {
            return (current_index > 9);
        }

        public override string CurrentItem()
        {
            if (!IsDone())
                return aggregate.months[current_index];
            else
                throw new Exception();
        }
    }

    // Will return all Winter months
    public class WinterIterator : Iterator
    {
        int current_index;

        public WinterIterator(ConcreteAggregate agg)
        {
            aggregate = agg;
        }

        public override void First()
        {
            current_index = 10;
        }

        public override void Next()
        {
            current_index++;
        }

        public override bool IsDone()
        {
            return (current_index > 12);
        }

        public override string CurrentItem()
        {
            if (!IsDone())
                return aggregate.months[current_index];
            else
                throw new Exception();
        }
    }

    // Will returns all months
    public class CalendarIterator: Iterator
    {
        int current_index;

        public CalendarIterator(ConcreteAggregate agg)
        {
            aggregate = agg;
        }

        public override void First()
        {
            current_index = 1;
        }

        public override void Next()
        {
            current_index++;
        }

        public override bool IsDone()
        {
            return (current_index > 12);
        }

        public override string CurrentItem()
        {
            if (!IsDone())
                return aggregate.months[current_index];
            else
                throw new Exception();
        }
    }
}
