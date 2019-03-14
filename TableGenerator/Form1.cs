using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strSQLScripts = GenerateSQLScripts();
            textBox1.Text = strSQLScripts;
        }

        public string GenerateSQLScripts()
        {
            string strScripts = string.Empty;
            List<TableClass> tables = new List<TableClass>();

            // Pass assembly name via argument
            //Assembly a = Assembly.LoadFile(args[0]);
            //Assembly a = Assembly.LoadFile(@"D:\Projects\Client-Rafael\FantasyDataApi\trunk\FantasyDataDotNet\Soccer\FantasyData.Soccer.Entities\bin\Debug\FantasyData.Soccer.Entities.dll");
            Assembly a = Assembly.LoadFile(@"D:\Project\Client-RG\FantasyDataApi\trunk\FantasyDataDotNet\NBA\FantasyData.NBA\bin\Debug\FantasyData.NBA.Entities.dll");

            Type[] types = a.GetTypes();

            // Get Types in the assembly.
            foreach (Type t in types)
            {
                TableClass tc = new TableClass(t);
                tables.Add(tc);
            }

            // Create SQL for each table
            foreach (TableClass table in tables)
            {
                strScripts += table.CreateTableScript() + Environment.NewLine;
                //Console.WriteLine(table.CreateTableScript());
                //Console.WriteLine();
            }
            return strScripts;
            // Total Hacked way to find FK relationships! Too lazy to fix right now
            foreach (TableClass table in tables)
            {
                foreach (KeyValuePair<String, Type> field in table.Fields)
                {
                    foreach (TableClass t2 in tables)
                    {
                        if (field.Value.Name == t2.ClassName)
                        {
                            // We have a FK Relationship!
                            Console.WriteLine("GO");
                            Console.WriteLine("ALTER TABLE " + table.ClassName + " WITH NOCHECK");
                            Console.WriteLine("ADD CONSTRAINT FK_" + field.Key + " FOREIGN KEY (" + field.Key + ") REFERENCES " + t2.ClassName + "(ID)");
                            Console.WriteLine("GO");

                        }
                    }
                }
            }
        }
    }

}
