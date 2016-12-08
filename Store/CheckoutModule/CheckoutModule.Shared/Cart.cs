﻿namespace CheckoutModule
{
    using Contracts;
    using System.Collections.Generic;

    // Thread-safe Singleton!
    public sealed class Cart
    {
        private static volatile Cart chart;

        private Cart()
        {
            this.Items = new List<ISellable>();
        }

        private static object LockObject = new object();

        public static Cart UserChart
        {
            get
            {
                if (chart == null)
                {
                    lock (LockObject)
                    {
                        if (chart == null)
                        {
                            chart = new Cart();
                        }
                    }
                }

                return chart;
            }
        }

        internal string FirstName { get; set; } = "Emil";

        internal string LastName { get; set; } = "Mitev";

        internal decimal Money { get; set; } = 300.00m;

        internal IList<ISellable> Items { get; set; }
    }
}