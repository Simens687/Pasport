using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pasport
{
    class Pasport_dan
    {
        private string surename;
        public string Surename
        {
            get
            {
                return surename;
            }
            set
            {
                Regex pattern = new Regex(@"^[А-ЯЁ][а-яё]*$");
                if (!pattern.IsMatch(value))
                {
                    throw new ArgumentException("Можно вводить только русские буквы, без пробелов, цифр и символов");
                }

                surename = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                Regex pattern = new Regex(@"^[А-ЯЁ][а-яё]*$");
                if (!pattern.IsMatch(value))
                {
                    throw new ArgumentException("Можно вводить только русские буквы, без пробелов, цифр и символов");
                }

                name = value;
            }
        }

        private string fathername;
        public string Fathername
        {
            get
            {
                return fathername;
            }
            set
            {
                Regex pattern = new Regex(@"^[А-ЯЁ][а-яё]*$");
                if (!pattern.IsMatch(value))
                {
                    throw new ArgumentException("Можно вводить только русские буквы, без пробелов, цифр и символов");
                }

                fathername = value;
            }
        }

        public string sex;

        public DateOnly date_rozh;

        private string mest_rozh;

        public string Mest_rozh
        {
            get
            {
                return mest_rozh;
            }
            set
            {
                Regex pattern = new Regex(@"^[а-яА-Я\s.]+$");
                if (!pattern.IsMatch(value))
                {
                    throw new ArgumentException("Можно вводить только русские буквы, пробелы и .");
                }

                mest_rozh = value;
            }
        }

        private string ser_num;

        public string Ser_num
        {
            get
            {
                return ser_num;
            }
            set
            {
                Regex pattern = new Regex(@"^\d{2} \d{2} \d{6}$");
                if (!pattern.IsMatch(value))
                {
                    throw new ArgumentException("Формат ввода = \"12 12 123456\"");
                }

                ser_num = value;
            }
        }

        private string hwo_vid;

        public string Hwo_vid
        {
            get
            {
                return hwo_vid;
            }
            set
            {
                Regex pattern = new Regex(@"^[а-яА-Я\s.]+$");
                if (!pattern.IsMatch(value))
                {
                    throw new ArgumentException("Можно вводить только русские буквы, пробелы и .");
                }

                hwo_vid = value;
            }
        }

        public DateOnly date_vidach;

        private string code_pod;

        public string Code_pod
        {
            get
            {
                return code_pod;
            }
            set
            {
                Regex pattern = new Regex(@"^\d{3}-\d{3}$");
                if (!pattern.IsMatch(value))
                {
                    throw new ArgumentException("Формат ввода = \"123-123\"");
                }

                code_pod = value;
            }
        }

    }
}
