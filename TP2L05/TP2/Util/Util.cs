﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
   public static class Util
    {
        public static bool IsValidEMail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsComplete(string txt)
        {
            if (txt.Equals(string.Empty) || string.IsNullOrWhiteSpace(txt)) return false;
            return true;
        }

        public static bool IsDate(string fechaentrante)
        {
            bool isDate = true;

            try
            {
                DateTime fecha = DateTime.ParseExact(fechaentrante, "YYYY-MM-DD", null);
            }

            catch (Exception e)
            {
                isDate = false;

                throw (e);
            }
            return isDate;
        }
    }
}