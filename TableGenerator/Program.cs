using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            List<TableClass> tables = new List<TableClass>();

            //###### Pass assembly name via argument
            //Assembly a = Assembly.LoadFile(args[0]);
            //Assembly a = Assembly.LoadFile(@"D:\Projects\Client-Rafael\FantasyDataApi\trunk\FantasyDataDotNet\FantasyData.Soccer.Entities\bin\Debug\FantasyData.Soccer.Entities.dll");
            //Assembly a = Assembly.LoadFile(@"E:\Client-R\FantasyDataApi\trunk\FantasyDataDotNet\FantasyData.NHL.Entities\bin\Debug\FantasyData.NHL.Entities.dll");
            Assembly a = Assembly.LoadFile(@"D:\Projects\GithubRepo\FantasyDataApi\NFL\FantasyData.NFL\bin\Debug\FantasyData.NFL");

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
                
                Console.WriteLine(table.CreateTableScript());
                Console.WriteLine();
            }

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

    public class TableClass
    {
        private List<KeyValuePair<String, Type>> _fieldInfo = new List<KeyValuePair<String, Type>>();
        private string _className = String.Empty;

        private Dictionary<Type, String> dataMapper
        {
            get
            {
                // Add the rest of your CLR Types to SQL Types mapping here
                Dictionary<Type, String> dataMapper = new Dictionary<Type, string>();
                dataMapper.Add(typeof(int), "INT");
                dataMapper.Add(typeof(string), "NVARCHAR(500)");
                dataMapper.Add(typeof(bool), "BIT");
                dataMapper.Add(typeof(DateTime), "DATETIME");
                dataMapper.Add(typeof(float), "FLOAT");
                dataMapper.Add(typeof(double), "DECIMAL(18,2)");
                dataMapper.Add(typeof(decimal), "DECIMAL(18,2)");
                dataMapper.Add(typeof(Guid), "UNIQUEIDENTIFIER");

                return dataMapper;
            }
        }

        public List<KeyValuePair<String, Type>> Fields
        {
            get { return this._fieldInfo; }
            set { this._fieldInfo = value; }
        }

        public string ClassName
        {
            get { return this._className; }
            set { this._className = value; }
        }

        public TableClass(Type t)
        {
            this._className = t.Name;

            foreach (PropertyInfo p in t.GetProperties())
            {
                KeyValuePair<String, Type> field = new KeyValuePair<String, Type>(p.Name, p.PropertyType);

                this.Fields.Add(field);
            }
        }

        public string CreateTableScript()
        {
            System.Text.StringBuilder script = new StringBuilder();

            script.AppendLine("CREATE TABLE ApiSoccer" + this.ClassName);
            script.AppendLine("(");
            script.AppendLine("\t ID INT,");
            for (int i = 0; i < this.Fields.Count; i++)
            {
                KeyValuePair<String, Type> field = this.Fields[i];

                if (dataMapper.ContainsKey(field.Value))
                {
                    script.Append("\t " + field.Key + " " + dataMapper[field.Value]);
                }
                else
                {
                    // Complex Type? 
                    script.Append("\t " + field.Key + " INT");
                }

                if (i != this.Fields.Count - 1)
                {
                    script.Append(",");
                }

                script.Append(Environment.NewLine);
            }

            script.AppendLine(")");

            return script.ToString();
        }
    }
}
