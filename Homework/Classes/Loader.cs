using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQXBY9.Classes
{
    internal class Loader
    {

        public List<T> loader<T>(string filepath)
        {
            List<Work> works = new List<Work>();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            WorkParser parser = new WorkParser();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] entries = reader.ReadLine().Split(';');
                        works.Add(parser.Parse(entries));
                    }
                }
            }

            return new List<T>(works as IEnumerable<T>);
        }
    }
}
