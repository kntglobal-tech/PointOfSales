﻿using System;
using System.Text;
using NLog;
using whostpos.Core.Interface;

namespace whostpos.Core.Classes
{
    public class NlogException :ILogExceptions
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public void LogException(Exception exception)
        {
            Logger.Error(CreateExceptionString(exception));
        }

        public string CreateExceptionString(Exception e)
        {
            var sb = new StringBuilder();
            CreateExceptionString(sb, e, string.Empty);

            return sb.ToString();
        }

        private void CreateExceptionString(StringBuilder sb, Exception e, string indent)
        {
            if (indent == null)
            {
                indent = string.Empty;
            }
            else if (indent.Length > 0)
            {
                sb.AppendFormat("{0}Inner ", indent);
            }

            sb.AppendFormat("Exception Found:\n{0}Type: {1}", indent, e.GetType().FullName);
            sb.AppendFormat("\n{0}Message: {1}", indent, e.Message);
            sb.AppendFormat("\n{0}Source: {1}", indent, e.Source);
            sb.AppendFormat("\n{0}Stack trace: {1}", indent, e.StackTrace);

            if (e.InnerException != null)
            {
                sb.Append("\n");
                CreateExceptionString(sb, e.InnerException, indent + "  ");
            }
        }
    }
}
