using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    //Our data source that gets updated regularly
    public class DataSource : Subject
    {
        private readonly List<string> _data = new();
        
        /// <summary>
        /// Add data to the datasource.
        /// </summary>
        /// <param name="data">Data we want to add.</param>
        public void AddData(string data)
        {
            _data.Add(data);
            Notify();
        }

        /// <summary>
        /// Remove data from data source.
        /// </summary>
        /// <param name="data">Data we want to remove.</param>
        public void RemoveData(string data)
        {
            _data.Remove(data);
            Notify();
        }
    }
}
